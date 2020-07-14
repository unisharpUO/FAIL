using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using ScriptSDK;
using StealthAPI;
using ScriptSDK.Data;
using ScriptSDK.Engines;
using ScriptSDK.Gumps;
using ScriptSDK.Items;
using ScriptSDK.Mobiles;
using ScriptSDK.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using MoreLinq;
using XScript.Scripts.unisharpUO;

namespace FAIL
{
    public partial class FAIL : Form
    {
        #region Vars
        //Global
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";
        private bool BuildingRail, BuildingRailPause, Searching, StealthSearch, Watching, PauseSearch = false;
        private bool RuneBlocked = false;
        private string CurrentShard, ShardDisplay;
        private int StartLocation = 0;
        private string RailFilePath, HouseFilePath, SettingsFilePath, LootListFilePath;
        private Rail SelectedRail, CurrentRail;
        private List<Rail> SelectedRails = new List<Rail>();
        private List<uint> Runebooks = new List<uint>();
        private Object thisLock = new Object();
        private DataSet DataSetHouses = new DataSet();
        [XmlArray]
        private List<Rail> Rails = new List<Rail>();
        [XmlArray]
        private List<House> Houses = new List<House>();
        private List<House> CurrentHouses = new List<House>();
        private List<Setting> Settings = new List<Setting>();

        //Loot
        private List<Loot> LootList = new List<Loot>();
        private DataSet DataSetLootList = new DataSet();
        private bool StealthLoot;
        #endregion Vars

        #region Form
        public FAIL()
        {
            InitializeComponent();

            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                System.Deployment.Application.ApplicationDeployment ad =
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                Text = String.Format("FAIL (Fully Automated IDOC Looter) {0}", ad.CurrentVersion);
            }
            
            string _myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string _scriptPath = _myDocuments + "\\Stealth\\FAIL";

            //RailFilePath = _scriptPath + "\\rails.xml";
            LootListFilePath = _scriptPath + "\\lootlist.xml";
            HouseFilePath = _scriptPath + "\\houses.xml";
            SettingsFilePath = _scriptPath + "\\settings.xml";
        }
        private void FAIL_Load(object sender, EventArgs e)
        {
            try
            {
                if (!(Stealth.Client.GetConnectedStatus()))
                    MessageBox.Show("Please connect a profile in Stealth and try again.");

                var Player = PlayerMobile.GetPlayer();
                Player.Backpack.DoubleClick();
                
                if (File.Exists(HouseFilePath))
                    LoadHouses();
                if (File.Exists(SettingsFilePath))
                    LoadSettings();
                if (File.Exists(LootListFilePath))
                    LoadLootList();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void FAIL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BuildingRail)
            {
                workerBuildRail.CancelAsync();
                Enabled = false;
                e.Cancel = true;
            }
        }
        private void FAIL_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void cboxShardDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void rdoSelectedRail_CheckedChanged(object sender, EventArgs e)
        {
        }
        #endregion

        #region Buttons
        private void btnAddRunebook_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Select runebook to add...");
                Item _itemRunebook = GetTargetItem();

                Runebooks.Add(_itemRunebook.Serial.Value);

                listRunebooks.DataSource = null;
                listRunebooks.DataSource = Runebooks;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void btnRemoveRunebook_Click(object sender, EventArgs e)
        {
            try
            {
                if (listRunebooks.SelectedIndex == -1)
                    MessageBox.Show("There was no runebook selected to remove.");
                else
                {
                    var _runebookID = Convert.ToUInt32(listRunebooks.SelectedItem.ToString());

                    if (Rails.Any(x => x.RunebookID == _runebookID))
                        MessageBox.Show("Runebook is being used in an existed rail, remove the rail first.");
                    else
                    {
                        Runebooks.RemoveAt(listRunebooks.SelectedIndex);

                        listRunebooks.DataSource = null;
                        listRunebooks.DataSource = Runebooks;
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void btnAddRail_Click(object sender, EventArgs e)
        {
            try
            {
                if (listRunebooks.SelectedIndex == -1)
                    MessageBox.Show("Select a runebook this rail be referenced to, and try again.");
                else if (Convert.ToInt32(txtRuneNumber.Text) < 0 || Convert.ToInt32(txtRuneNumber.Text) > 16)
                    MessageBox.Show("Rune number can't be less than 0 or greater than 16.");
                else if (txtRailName == null)
                    MessageBox.Show("Please enter a name for the rail.");
                else
                {
                    Rail _rail = new Rail(txtRailName.Text, Convert.ToUInt32(listRunebooks.SelectedValue.ToString()), Convert.ToUInt16(txtRuneNumber.Text));
                    Rails.Add(_rail);

                    List<string> _railNames = new List<string>();

                    foreach (Rail _r in Rails)
                    {
                        _railNames.Add(_r.Name);
                    }

                    listRails.DataSource = null;
                    listRails.DataSource = _railNames;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.StackTrace.ToString());
            }
        }
        private void btnRemoveRail_Click(object sender, EventArgs e)
        {
            if (listRails.SelectedIndex == -1)
                MessageBox.Show("Select rails to remove.");
            else
            {
                try
                {
                    SelectedRails.Clear();

                    for (int x = 0; x < listRails.Items.Count; x++)
                    {
                        if (listRails.GetSelected(x) == true)
                            Rails.Remove(Rails[x]);
                    }

                    List<string> _railNames = new List<string>();

                    foreach (Rail _r in Rails)
                    {
                        _railNames.Add(_r.Name);
                    }

                    listRails.DataSource = null;
                    listRails.DataSource = _railNames;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }
        private void btnStartRail_Click(object sender, EventArgs e)
        {
            if (listRails.SelectedIndex == -1)
                MessageBox.Show("Select a rail to start building.");
            else
            {
                try
                {
                    SelectedRail = Rails[listRails.SelectedIndex];
                    BuildingRail = true;
                    BuildingRailPause = false;
                    workerBuildRail.RunWorkerAsync();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }
        private void btnStopRail_Click(object sender, EventArgs e)
        {
            BuildingRail = false;
            workerBuildRail.CancelAsync();
        }
        private void btnSaveRails_Click(object sender, EventArgs e)
        {
            try
            {
                if (RailFilePath == null)
                {
                    MessageBox.Show("Please select a rail file.");
                    return;
                }

                if (!File.Exists(RailFilePath))
                    CreateXMLFile(RailFilePath);

                txtStatus.AppendLine("Saving rail settings...");
                XmlSerializer _serializer = new XmlSerializer(typeof(List<Rail>));
                using (TextWriter _writer = new StreamWriter(RailFilePath))
                {
                    _serializer.Serialize(_writer, Rails);
                }
                txtStatus.AppendLine("Rail settings saved!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void btnLoadRails_Click(object sender, EventArgs e)
        {
            LoadRails();
        }
        private void btnResetRails_Click(object sender, EventArgs e)
        {
        }
        private void btnStartSearch_Click(object sender, EventArgs e)
        {
            if (!workerSearch.IsBusy)
            {
                if (RailFilePath == null)
                    MessageBox.Show("No rail file selected.");
                else if (listRails.SelectedIndex == -1)
                    MessageBox.Show("Select rails to start searching.");
                else if (cboxShardSelect.SelectedIndex == -1)
                    MessageBox.Show("Select shard to start searching.");
                else
                {
                    try
                    {
                        if (txtStartLocation.Text != "")
                        {
                            StartLocation = Convert.ToInt16(txtStartLocation.Text);
                        }

                        SelectedRails.Clear();

                        string _selectedRails = "";

                        for (int x = 0; x < listRails.Items.Count; x++)
                        {
                            if (listRails.GetSelected(x) == true)
                            {
                                SelectedRails.Add(Rails[x]);
                                _selectedRails += Rails[x].Name + ' ';
                            }
                        }

                        CurrentShard = cboxShardSelect.Text;
                        CurrentRail = SelectedRails.First();

                        StealthSearch = cboxStealthSearch.Checked;
                        Searching = true;
                        btnStartSearch.Enabled = false;
                        txtStatus.AppendLine("Rails selected: " + _selectedRails);
                        workerCheckHouses.RunWorkerAsync();
                        workerSearch.RunWorkerAsync();
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show(x.Message.ToString());
                    }
                }
            }
        }
        private void btnStopSearch_Click(object sender, EventArgs e)
        {
            Searching = false;
            workerSearch.CancelAsync();
            workerCheckHouses.CancelAsync();
        }
        private void btnSaveHouses_Click(object sender, EventArgs e)
        {
            SaveHouses();
        }
        private void btnLoadHouses_Click(object sender, EventArgs e)
        {
            LoadHouses();
        }
        private void btnDebugGetID_Click(object sender, EventArgs e)
        {
            /*
            Item _result = GetTargetItem();

            List<ClilocItemRec> _properties = Stealth.Client.GetClilocRec(_result.Serial.Value);

            txtDebugStatus.AppendLine(_properties.Count.ToString());

            foreach (ClilocItemRec _property in _properties)
            {
                txtDebugStatus.AppendLine(_property.ClilocID.ToString());
                foreach (String _param in _property.Params)
                {
                    txtDebugStatus.AppendLine(_param.ToString());
                }
            }

            txtDebugStatus.AppendLine(_result.Tooltip);
            */

            Item _result = GetTargetItem();

            _result.DoubleClick();
            Gump.WaitForGump(_result.Serial.Value, 1200);



            List<Gump> tmp = ScriptSDK.Gumps.Gump.ActiveGumps;

            Gump test = Gump.GetGump(_result.Serial);

            GumpButton testButton = test.Buttons[50];

            testButton.Click();

            txtDebugStatus.AppendLine(_result.Serial.ToString());
            txtDebugStatus.AppendLine(tmp.Count.ToString());

            //Gump tmp1 = ScriptSDK.Gumps.Gump(); .GetGump((uint)0x005C0198);
            /*List<GumpButton> button = tmp[0].Buttons;
            List<GumpTextEdit> edit = tmp[0].TextEdits;
            List<GumpHtml> html = tmp[0].HTMLTexts;
            List<GumpHtmlLocalized> htmllocal = tmp[0].HTMLLocalizedTexts;
            //System.String xxx = "123";
            //edit[0].Text = xxx;
            ScriptLogger.WriteLine(String.Format("Serial: {0}", tmp[0].Serial));
            ScriptLogger.WriteLine(String.Format("GumpType: {0}", tmp[0].GumpType));
            ScriptLogger.WriteLine(String.Format("ButtonCount: {0}", button.Count));
            ScriptLogger.WriteLine(String.Format("EditCount: {0}", edit.Count));
            ScriptLogger.WriteLine(String.Format("HtmlCount: {0}", html.Count));
            ScriptLogger.WriteLine(String.Format("HtmlLocalCount: {0}", htmllocal.Count));

            txtDebugStatus.AppendLine("Test");
            */






            /*
            int _homeButton = 49 + Rune;
            GumpButton _tempButton;
            Point2D _point;
            _point.X = 1;


            _tempButton.ArtLocation = Point2D(_runebook.Serial, _homeButton);

            Gump.Click(_runebook.Serial, _homeButton);*/



        }
        private void btnDebugSearchItems_Click(object sender, EventArgs e)
        {
            try
            {
                ScriptLogger.Initialize();
                ScriptLogger.LogToStealth = true;
                Scanner.Range = 20;
                Scanner.VerticalRange = 20;

                var Player = PlayerMobile.GetPlayer();
                var results = Scanner.Find<HouseSigns>(0x0, false);
                List<HouseSigns> list = results.Select(x => x.Cast<HouseSigns>()).ToList();

                string _textToSend = "";

                txtDebugStatus.AppendLine(list.Count.ToString());
                foreach (Item _item in list)
                {
                    string[] _text = _item.Tooltip.Split('|');
                    txtDebugStatus.AppendLine("DEBUG");
                    foreach (String _char in _text)
                    {
                        txtDebugStatus.AppendLine(_char);
                    }
                    txtDebugStatus.AppendLine("DEBUG");

                    for (int x = 0; x < _text.Count(); x++)
                    {
                        if (_text[x].Remove(6) == "Name: ")
                            _textToSend = _text[x].Remove(0, 6) + " ";
                        else if (_text[x].Remove(7) == "Owner: ")
                            _textToSend = _text[x].Remove(0, 7) + " ";
                        if (_text[x].Length > 11)
                            if (_text[x].Remove(11) == "Condition: ")
                                _textToSend = _text[x].Remove(0, 11) + " ";
                            else
                                _textToSend = "Refreshed";
                    }

                    txtDebugStatus.AppendLine(_textToSend);
                    txtDebugStatus.AppendLine(_item.Tooltip);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void btnSetSafeRunebook_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Select runebook...");
                Item _itemRunebook = GetTargetItem();

                var _currentSetting = Settings.Where(x => x.Shard == cboxSettingShard.Text);

                if (_currentSetting.Count() > 0)
                {
                    _currentSetting.First().HomeRunebookID = _itemRunebook.Serial.Value;
                }
                else
                    Settings.Add(new Setting(cboxSettingShard.Text,
                        _itemRunebook.Serial.Value,
                        Convert.ToInt16(txtSafeRuneNumber.Text)
                        ));
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(SettingsFilePath))
                    CreateXMLFile(SettingsFilePath);

                txtStatus.AppendLine("Saving general settings...");
                XmlSerializer _serializer = new XmlSerializer(typeof(List<Setting>));
                using (TextWriter _writer = new StreamWriter(SettingsFilePath))
                {
                    _serializer.Serialize(_writer, Settings);
                }
                txtStatus.AppendLine("General settings saved!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }
        private void btnRefreshDataGrid_Click(object sender, EventArgs e)
        {
            if (cboxShardDisplay.SelectedIndex == -1)
                MessageBox.Show("Select shard to display.");
            else
            {
                ShardDisplay = cboxShardDisplay.Text;
                UpdateGridView();
            }
                
        }
        private void btnPauseBuildRail_Click(object sender, EventArgs e)
        {
            BuildingRailPause = true;
            txtStatus.AppendLine("Paused building rail...");
        }
        private void btnContinueBuildRail_Click(object sender, EventArgs e)
        {
            BuildingRailPause = false;
            txtStatus.AppendLine("Resumed building rail...");
        }
        private void btnRailFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Stealth\\FAIL";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;


            DialogResult _result = openFileDialog1.ShowDialog();
            if (_result == DialogResult.OK)
            {
                RailFilePath = openFileDialog1.FileName;

                if (File.Exists(RailFilePath))
                {
                    LoadRails();
                    lblRailFile.Text = openFileDialog1.SafeFileName;
                }
            }
        }
        private void btnCreateNewRail_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
        }
        private void btnPauseSearch_Click(object sender, EventArgs e)
        {
            PauseSearch = !PauseSearch;
        }

        private void btnCalendarConnect_Click(object sender, EventArgs e)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                txtCalendarOutput.AppendLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Google.Apis.Calendar.v3.Data.Events events = request.Execute();
            txtCalendarOutput.AppendLine("Upcoming events:");
            if (events.Items != null && events.Items.Count > 0)
            {
                foreach (var eventItem in events.Items)
                {
                    string when = eventItem.Start.DateTime.ToString();
                    if (String.IsNullOrEmpty(when))
                    {
                        when = eventItem.Start.Date;
                    }
                    txtCalendarOutput.AppendLine(eventItem.Summary + " (" + when + ')');
                }
            }
            else
            {
                txtCalendarOutput.AppendLine("No upcoming events found.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            workerCheckHouses.RunWorkerAsync();
        }

        //Watch
        private void btnStartWatching_Click(object sender, EventArgs e)
        {
            Watching = true;
            StealthLoot = cboxStealthLoot.Checked;
            btnStartWatching.Enabled = false;
            workerWatch.RunWorkerAsync();
        }

        //Loot
        private void btnAddLootTarget_Click(object sender, EventArgs e)
        {
            Item _item = TargetExtensions.RequestTarget();
            LootList.Add(new Loot(_item));
            UpdateGridLootList();
        }
        private void btnAddLootType_Click(object sender, EventArgs e)
        {
            var _type = Convert.ToUInt16(txtAddlootType.Text);
            LootList.Add(new Loot(_type));
            UpdateGridLootList();
        }
        private void btnAddLootName_Click(object sender, EventArgs e)
        {
            var _name = txtAddLootName.Text;
            LootList.Add(new Loot(_name));
            UpdateGridLootList();
        }
        private void btnSaveLootList_Click(object sender, EventArgs e)
        {
            SaveLootList();
        }
        private void btnLootTest_Click(object sender, EventArgs e)
        {
            PlayerMobile Self = PlayerMobile.GetPlayer();
            Stealth.Client.SetMoveThroughNPC(0);
            Scanner.Range = 20;
            Scanner.VerticalRange = 20;
            List<Item> _items = new List<Item>();
            List<uint> _findList = new List<uint>();

            Stealth.Client.FindTypeEx(0xFFFF, 0xFFFF, 0x0, false);
            if (!(Stealth.Client.GetFindCount() == 0))
                _findList = Stealth.Client.GetFindList();

            foreach (uint _itemID in _findList)
            {
                var _item = (new Item(new Serial(_itemID)));
                _item.UpdateTextProperties();
                var _name = _item.Tooltip.Split('|')[0].Replace("'", "");

                if (LootList.Where(x => x.LootName == _name).Count() > 0)
                    _items.Add(_item);
            }

            foreach (var _item in _items)
            {
                _item.UpdateLocalizedProperties();
                _item.UpdateTextProperties();
                if (_item.Valid)
                {
                    Self.Movement.newMoveXY((ushort)_item.Location.X, (ushort)_item.Location.Y, true, 1, StealthLoot ? false : true);
                    _item.Grab();
                }
            }
        }

        #endregion

        #region Worker Functions

        //Search
        private void workerSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            Stealth.Client.ClilocSpeech += onClilocSpeech;
            PlayerMobile Self = PlayerMobile.GetPlayer();
            Stealth.Client.SetMoveThroughNPC(0);
            while (Searching)
            {
                foreach (Rail _rail in SelectedRails)
                {
                    lock (thisLock)
                    {
                        CurrentRail = _rail;

                        if (StartLocation == 0)
                        {
                            workerSearch.ReportProgress(0, "Starting rail: " + CurrentRail.Name);
                            workerSearch.ReportProgress(0, "Recalling to start spot...");
                            Recall(_rail.RunebookID, _rail.RuneNumber);
                            Thread.Sleep(5000);

                            /*if (StealthSearch)
                                Stealth.Client.UseSkill("Hiding");*/
                        }

                        int _pathLocations = _rail.Path.Count();
                        string _textToReport = _pathLocations.ToString() + " locations found!";
                        workerSearch.ReportProgress(0, _textToReport);
                        workerSearch.ReportProgress(0, "Starting search...");
                    }

                    /*
                    if (!workerCheckHouses.IsBusy)
                        workerCheckHouses.RunWorkerAsync();
                        */

                    int _n = StartLocation;
                    foreach (Location _location in _rail.Path.Skip(StartLocation))
                    {
                        
                        lock (thisLock)
                        {
                            _n++;

                            Point2D _position = new Point2D(_location.X, _location.Y);

                            workerSearch.ReportProgress(0, "Moving to location " + _n.ToString() + _position.ToString());

                            Stealth.Client.newMoveXY((ushort)_location.X, (ushort)_location.Y, true, 10,
                                StealthSearch ? false : true);

                            while (!Geometry.InRange(Self.Location, _position, 16))
                            {

                                while (PauseSearch) Thread.Sleep(1000);

                                if (workerSearch.CancellationPending)
                                {
                                    e.Cancel = true;
                                    break;
                                }

                                workerSearch.ReportProgress(0, "trying to move  to: " + _position.ToString());

                                Self.Movement.Step(Convert.ToByte(Geometry.GetDirectionTo(Self.Location, _position)), true);

                                Stealth.Client.newMoveXY((ushort)_location.X, (ushort)_location.Y, true, 10,
                                StealthSearch ? false : true);
                            }

                            if (workerSearch.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }

                        }
                    } //end foreach location


                    //workerCheckHouses.CancelAsync();

                    /* * *
                     * If the search didn't end early, check all the houses
                     * of the rail we just searched and mark the ones that
                     * were not updated recently as collapsed
                     * */
                    if (!workerSearch.CancellationPending)
                    {
                        var _housesInCurrentRail = CurrentHouses.Where(x => x.Rail == CurrentRail.Name).ToList();
                        foreach (House _house in _housesInCurrentRail)
                        {
                            TimeSpan _ts = DateTime.Now - _house.Checked;
                            if (_ts.Days > 1)
                            {
                                _house.Condition = "Collapsed";
                            }
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                        break;
                    }
                    
                } //end foreach rail

                workerSearch.ReportProgress(0, "Recalling to home...");

                var _setting = Settings.Where(x => x.Shard == CurrentShard).First();

                Recall(_setting.HomeRunebookID, _setting.HomeRuneNumber);
                Thread.Sleep(5000);
                //Stealth.Client.UseSkill("Hiding");
                
                Searching = false;
                workerSearch.CancelAsync();
                workerCheckHouses.CancelAsync();
            }
        }
        private void workerSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtStatus.AppendLine(e.UserState.ToString());
        }
        private void workerSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Stealth.Client.ClilocSpeech -= onClilocSpeech;

            txtStatus.AppendLine("Stopped searching!");
            
            if (e.Cancelled)
                txtStatus.AppendLine("Searching was cancelled early.");
            else if (e.Error != null)
                txtStatus.AppendLine("Error. Details: " + (e.Error as Exception).ToString());


            btnStartSearch.Enabled = true;

        }
        private void workerCheckHouses_DoWork(object sender, DoWorkEventArgs e)
        {
            Scanner.Range = 20;
            Scanner.VerticalRange = 20;
            PlayerMobile Self = PlayerMobile.GetPlayer();

            List<uint> _checkedHouses = new List<uint>();

            workerCheckHouses.ReportProgress(0, "Starting search");
            while (Searching)
            {
                lock (thisLock)
                {
                    if (workerCheckHouses.CancellationPending)
                        break;

                    var _results = Scanner.Find<HouseSigns>(0x0, false);
                    List<HouseSigns> _houseSigns = _results.Select(x => x.Cast<HouseSigns>()).ToList();

                    foreach (Item _houseSign in _houseSigns)
                    {
                        _houseSign.UpdateTextProperties();

                        //if we just checked the house, don't go through any more logic
                        if (_checkedHouses.Contains(_houseSign.Serial.Value))
                            continue;

                        var _serial = _houseSign.Serial.Value;
                        House _house = new House(_serial, CurrentShard, _houseSign.Tooltip, CurrentRail.Name, Self.Location.X, Self.Location.Y);
                        CurrentHouses.Add(_house);
                        _checkedHouses.Add(_serial);

                        workerCheckHouses.ReportProgress(0, "Found house: " + _serial.ToString());
                        
                        /*
                        //if the house doesn't exist, add the new record to the temporary list
                        if (!Houses.Any(x => x.ID == _item.Serial.Value))
                        {
                            var _serial = _item.Serial.Value;
                            workerCheckHouses.ReportProgress(0, "New house added!");
                            House _house = new House(_serial, CurrentShard, _item.Tooltip, CurrentRail.Name, Self.Location.X, Self.Location.Y);
                            CurrentHouses.Add(_house);
                            _checkedHouses.Add(_serial);
                        }
                        //if the house already existed, add the updated record to the temporary list
                        else
                        {
                            workerCheckHouses.ReportProgress(0, "Updating house...");
                            House _house = Houses.Find(x => x.ID == _item.Serial.Value);
                            _house.Checked = DateTime.Now;
                            _house.Tooltip = _item.Tooltip;

                            string[] _text = _item.Tooltip.Split('|');

                            for (int x = 0; x < _text.Count(); x++)
                            {
                                if (_text[x].Length > 11)
                                    if (_text[x].Remove(11) == "Condition: ")
                                        _house.Condition = _text[x].Remove(0, 11);
                                    else
                                        _house.Condition = "Refreshed";
                            }
                        }*/


                    }
                }
            }
        }
        private void workerCheckHouses_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtHouseStatus.AppendLine(e.UserState.ToString());
        }
        private void workerCheckHouses_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("The task has been cancelled");
            else if (e.Error != null)
                MessageBox.Show("Error. Details: " + (e.Error as Exception).ToString());

            txtHouseStatus.AppendLine("Check Houses Stopped!");
            SaveHouses();

        }
        private void workerBuildRail_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtStatus.AppendLine(e.UserState.ToString());
        }
        private void workerBuildRail_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            txtStatus.AppendLine("Rail building ended!");
            if (e.Cancelled)
            {
                MessageBox.Show("The task has been cancelled");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error. Details: " + (e.Error as Exception).ToString());
            }
            else
            {
                MessageBox.Show("The task has been completed. Results: " + e.Result.ToString());
            }
        }
        private void workerBuildRail_DoWork(object sender, DoWorkEventArgs e)
        {
            PlayerMobile Self = PlayerMobile.GetPlayer();
            workerBuildRail.ReportProgress(0, "Building rail, start running around!");

            int _n = 0;

            while (BuildingRail)
            {
                if (BuildingRailPause)
                {
                    Thread.Sleep(1000);
                    continue;
                }

                _n++;
                if (workerBuildRail.CancellationPending)
                    break;

                workerBuildRail.ReportProgress(0, "Updating path (" + _n + ")");

                int _x, _y;
                _x = Self.Location.X;
                _y = Self.Location.Y;

                Location _location = new Location(_x, _y);

                SelectedRail.Path.Add(_location);
                Thread.Sleep(2500);
            }
        }

        //Watch
        private void workerWatch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            txtWatchStatus.AppendLine(e.UserState.ToString());
        }
        private void workerWatch_DoWork(object sender, DoWorkEventArgs e)
        {
            PlayerMobile Self = PlayerMobile.GetPlayer();
            Stealth.Client.SetMoveThroughNPC(0);
            Scanner.Range = 20;
            Scanner.VerticalRange = 20;
            var _results = Scanner.Find<HouseSigns>(0x0, false);
            List<HouseSigns> _resultsList = _results.Select(x => x.Cast<HouseSigns>()).ToList();

            DateTime _start = DateTime.Now;

            if (_resultsList.Count == 0)
            {
                workerWatch.CancelAsync();
                Watching = false;
            }

            string[] _text = new string[] { "" };
            string _condition = "";
            string _oldCondition = "";

            var _houseSign = _resultsList.First();

            _houseSign.UpdateTextProperties();
            _houseSign.UpdateLocalizedProperties();

            _text = _houseSign.Tooltip.Split('|');

            if (_houseSign.Tooltip.Length > 11)
                for (int x = 0; x < _text.Count(); x++)
                {
                    if (_text[x].Length > 11)
                        if (_text[x].Remove(11) == "Condition: ")
                            _oldCondition = _text[x].Remove(0, 11);
                        else
                            _oldCondition = "Refreshed";
                }

            workerWatch.ReportProgress(0, DateTime.Now.ToString() + ": " + _oldCondition);

            while (Watching)
            {
                DateTime _time = DateTime.Now;

                if (!(Stealth.Client.IsObjectExists(_houseSign.Serial.Value)))
                {
                    workerWatch.ReportProgress(0, DateTime.Now.ToString() + ": " + "House just fell, start looting!");
                    
                    List<Item> _items = new List<Item>();
                    List<uint> _findList = new List<uint>();

                    Stealth.Client.FindTypeEx(0xFFFF, 0xFFFF, 0x0, false);
                    if (!(Stealth.Client.GetFindCount() == 0))
                        _findList = Stealth.Client.GetFindList();

                    foreach (uint _itemID in _findList)
                    {
                        var _item = (new Item(new Serial(_itemID)));
                        _item.UpdateTextProperties();
                        var _name = _item.Tooltip.Split('|')[0].Replace("'", "");

                        if (LootList.Where(x => x.LootName == _name).Count() > 0)
                            _items.Add(_item);
                    }

                    foreach (var _item in _items)
                    {
                        _item.UpdateLocalizedProperties();
                        _item.UpdateTextProperties();
                        if (_item.Valid)
                        {
                            workerWatch.ReportProgress(0, DateTime.Now.ToString() + ": " + "Looting Item: " + _item.Tooltip.Split('|')[0].Replace("'", ""));
                            Self.Movement.newMoveXY((ushort)_item.Location.X, (ushort)_item.Location.Y, true, 1, StealthLoot ? false : true);
                            _item.Grab();
                        }
                    }
                    workerWatch.ReportProgress(0, DateTime.Now.ToString() + ": " + "Done looting!");
                }

                _houseSign.UpdateTextProperties();
                _text = _houseSign.Tooltip.Split('|');

                if (_houseSign.Tooltip.Length > 11)
                    for (int x = 0; x < _text.Count(); x++)
                    {
                        if (_text[x].Length > 11)
                            if (_text[x].Remove(11) == "Condition: ")
                                _condition = _text[x].Remove(0, 11);
                            else
                                _condition = "Refreshed";
                    }

                if (_condition != _oldCondition)
                {
                    workerWatch.ReportProgress(0, DateTime.Now.ToString() + ": " + _condition);
                    _oldCondition = _condition;
                }

                Stealth.Client.Wait(500);
            }
        }
        private void workerWatch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnStartWatching.Enabled = true;
        }
        #endregion Worker Functions

        #region Methods
        public void ShowMyDialogBox()
        {
            NewRailFile testDialog = new NewRailFile();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                if (testDialog.NewRailFileName != "")
                {
                    string _myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string _scriptPath = _myDocuments + "\\Stealth\\FAIL";

                    RailFilePath = _scriptPath + "\\" + testDialog.NewRailFileName + ".xml";
                    lblRailFile.Text = testDialog.NewRailFileName;
                    CreateXMLFile(RailFilePath);
                    MessageBox.Show(RailFilePath);
                }
            }
            testDialog.Dispose();
        }
        public Item GetTargetItem()
        {
            Stealth.Client.ClientRequestObjectTarget();
            while (Stealth.Client.ClientTargetResponsePresent() == false) ;
            return new Item(new Serial(Stealth.Client.ClientTargetResponse().ID));
        }
        private void CreateXMLFile(string Filename)
        {
            XmlDocument _doc = new XmlDocument();
            XmlNode _docNode = _doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            _doc.AppendChild(_docNode);
            XmlNode _rootNode = _doc.CreateElement("ArrayOfRail");
            _doc.AppendChild(_rootNode);
            StreamWriter _outStream = File.CreateText(Filename);
            _doc.Save(_outStream);
            _outStream.Close();
        }


        private void UpdateGridView()
        {
            try
            {
                if (ShardDisplay != "ALL")
                {
                    var _houses = Houses.Where(x => x.Shard == ShardDisplay);
                    DataSetHouses = new DataSet();
                    DataSetHouses.Tables.Add(_houses.ToDataTable());
                }
                else
                {
                    DataSetHouses = new DataSet();
                    DataSetHouses.Tables.Add(Houses.ToDataTable());
                }
                
                DataSetHouses.Locale = CultureInfo.InvariantCulture;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = DataSetHouses;
                dataGridView1.DataMember = "DataTable";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void UpdateGridLootList()
        {

            try
            {
                DataSetLootList = new DataSet();
                DataSetLootList.Tables.Add(LootList.ToDataTable());
                DataSetLootList.Locale = CultureInfo.InvariantCulture;
                dataLootList.AutoGenerateColumns = true;
                dataLootList.DataSource = DataSetLootList;
                dataLootList.DataMember = "DataTable";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void SaveHouses()
        {
            try
            {
                if (!File.Exists(HouseFilePath))
                    CreateXMLFile(HouseFilePath);

                LoadHouses();

                Houses = Houses.DistinctBy(x => x.ID).ToList();

                foreach (House _house in CurrentHouses)
                {
                    
                    if (Houses.Where(x => x.ID == _house.ID && x.Shard == _house.Shard).Count() > 0)
                    {
                        House _houseToUpdate = Houses.Where(x => x.ID == _house.ID).First();
                        _houseToUpdate.Checked = _house.Checked;
                        _houseToUpdate.Tooltip = _house.Tooltip;

                        string[] _text = _house.Tooltip.Split('|');

                        for (int x = 0; x < _text.Count(); x++)
                        {
                            if (_text[x].Length > 11)
                                if (_text[x].Remove(11) == "Condition: ")
                                    _house.Condition = _text[x].Remove(0, 11);
                                else
                                    _house.Condition = "Refreshed";
                        }
                    }
                    else
                        Houses.Add(_house);

                }


                txtStatus.AppendLine("Saving houses...");
                XmlSerializer _serializer = new XmlSerializer(typeof(List<House>));
                using (TextWriter _writer = new StreamWriter(HouseFilePath))
                {
                    _serializer.Serialize(_writer, Houses);
                }
                txtStatus.AppendLine("Houses saved!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void LoadHouses()
        {
            try
            {
                XmlSerializer _deserializer = new XmlSerializer(typeof(List<House>));
                TextReader _reader = new StreamReader(HouseFilePath);
                object obj = _deserializer.Deserialize(_reader);
                Houses = (List<House>)obj;
                _reader.Close();

                /*
                List<string> _houseNames = new List<string>();

                foreach (House _house in CurrentHouses)
                {
                    _houseNames.Add(_house.Tooltip);
                }
                */

                txtStatus.AppendLine("Houses loaded!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void SaveLootList()
        {
            try
            {
                if (!File.Exists(LootListFilePath))
                    CreateXMLFile(LootListFilePath);

                txtStatus.AppendLine("Saving Loot List...");
                XmlSerializer _serializer = new XmlSerializer(typeof(List<Loot>));
                using (TextWriter _writer = new StreamWriter(LootListFilePath))
                {
                    _serializer.Serialize(_writer, LootList);
                }
                txtStatus.AppendLine("Loot List saved!");

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void LoadLootList()
        {
            try
            {
                XmlSerializer _deserializer = new XmlSerializer(typeof(List<Loot>));
                TextReader _reader = new StreamReader(LootListFilePath);
                object obj = _deserializer.Deserialize(_reader);
                LootList = (List<Loot>)obj;
                _reader.Close();
                txtStatus.AppendLine("Loot List loaded!");
                UpdateGridLootList();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void LoadSettings()
        {
            try
            {
                XmlSerializer _deserializer = new XmlSerializer(typeof(List<Setting>));
                TextReader _reader = new StreamReader(SettingsFilePath);
                object obj = _deserializer.Deserialize(_reader);
                Settings = (List<Setting>)obj;
                _reader.Close();

                txtStatus.AppendLine("Settings loaded!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void Recall(uint Runebook, int Rune)
        {
            Item _runebook = new Item(new Serial(Runebook));
            _runebook.DoubleClick();
            Gump.WaitForGump(_runebook.Serial.Value, 1200);
            Gump _runebookGump = Gump.GetGump(_runebook.Serial);
            int _homeButton = 31 + Rune;
            GumpButton _testButton = _runebookGump.Buttons[_homeButton];

            _testButton.Click();

            /*
            int _homeButton = 49 + Rune;
            GumpButton _tempButton;
            Point2D _point;
            _point.X = 1;


            _tempButton.ArtLocation = Point2D(_runebook.Serial, _homeButton);

            Gump.Click(_runebook.Serial, _homeButton);*/
        }
        private void LoadRails()
        {
            try
            {
                XmlSerializer _deserializer = new XmlSerializer(typeof(List<Rail>));
                TextReader _reader = new StreamReader(RailFilePath);
                object obj = _deserializer.Deserialize(_reader);
                Rails = (List<Rail>)obj;
                _reader.Close();

                List<string> _railNames = new List<string>();
                Runebooks.Clear();

                foreach (Rail _r in Rails)
                {
                    _railNames.Add(_r.Name);
                    Runebooks.Add(_r.RunebookID);
                }

                Runebooks = Runebooks.Distinct().ToList();

                listRunebooks.DataSource = null;
                listRunebooks.DataSource = Runebooks;

                listRails.DataSource = null;
                listRails.DataSource = _railNames;

                txtStatus.AppendLine("Rails loaded!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        private void onClilocSpeech(object sender, ClilocSpeechEventArgs e)
        {
            switch (e.Text)
            {
                case "Something is blocking":
                    RuneBlocked = true;
                    break;
                default:
                    break;
            }
        }
        #endregion Methods
    }
}