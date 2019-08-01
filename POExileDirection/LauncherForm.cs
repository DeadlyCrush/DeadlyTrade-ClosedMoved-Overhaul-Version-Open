using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoUpdaterDotNET;
using Newtonsoft.Json;
using Ninja_Price.API.PoeNinja.Classes;

namespace POExileDirection
{
    public partial class LauncherForm : Form
    {
        #region ⨌⨌ DllImport for Invoke ⨌⨌
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out uint processId);

        public static string GetPathFromHandle(IntPtr hwnd)
        {
            uint pid = 0;
            GetWindowThreadProcessId(hwnd, out pid);
            Process procInform = Process.GetProcessById((int)pid);
            return procInform.MainModule.FileName.ToString();
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        #endregion

        NinjaForm frmNinja = null;

        private int nMoving = 0;
        private int nMovePosX = 0;
        private int nMovePosY = 0;

        public static int CNT_NINJACATEGORIES = 16;
        public static int g_NinjaFileMakeAndUpdateCNT = 0; // Make 16 + Update 16 ( 16 = CNT_NINJACATEGORIES )
        public static string g_NinjaUpdatedTime = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");

        public static string g_CurrentLeague = "Legion";
        public static string g_POELogPath = "NULL";
        public static string g_POELogFileName = "NULL";
        public static string g_strUILang = "NULL";
        public static bool g_bShowLocalChat = false;

        private bool g_bCanLaunchAddon = false;
        private bool g_bAddonLaunched = false;
        ControlForm frmMainControl = null;

        Common commonClass = new Common();

        private string g_NinjaDirectory = null;

        public static int g_Flask1 { get; set; }
        public static int g_Flask2 { get; set; }
        public static int g_Flask3 { get; set; }
        public static int g_Flask4 { get; set; }
        public static int g_Flask5 { get; set; }

        public static string g_FlaskTime1 { get; set; }
        public static string g_FlaskTime2 { get; set; }
        public static string g_FlaskTime3 { get; set; }
        public static string g_FlaskTime4 { get; set; }
        public static string g_FlaskTime5 { get; set; }

        public static bool g_bToggle1 { get; set; }
        public static bool g_bToggle2 { get; set; }
        public static bool g_bToggle3 { get; set; }
        public static bool g_bToggle4 { get; set; }
        public static bool g_bToggle5 { get; set; }

        public static string g_strMyNickName { get; set; }
        public static string g_strTRWait { get; set; }
        public static string g_strTRSold { get; set; }

        public static string g_strTRThanks { get; set; }
        public static string g_strTRResend { get; set; }
        public static string g_strTRAutoKick { get; set; }

        public static int resolution_height { get; set; }
        public static int resolution_width { get; set; }

        public static int g_nGridWidth { get; set; }
        public static int g_nGridHeight { get; set; }

        public static bool g_FocusLosing { get; set; }

        public static bool g_pinLOCK { get; set; }

        public static bool g_ZoneInfoExpanded { get; set; }

        #region ⨌⨌ Declaration for NINJA API ⨌⨌
        // POE.NINJA
        public static string PoeLeagueApiList = "http://api.pathofexile.com/leagues?type=main&compact=1";

        // 16 Types
        public static string CurrencyURL = "https://poe.ninja/api/data/currencyoverview?type=Currency&league=";
        public static string Fragments_URL = "https://poe.ninja/api/data/currencyoverview?type=Fragment&league=";
        public static string Incubators_URL = "https://poe.ninja/api/data/itemoverview?type=Incubator&league=";
        public static string Scarabs_URL = "https://poe.ninja/api/data/itemoverview?type=Scarab&league=";
        public static string Fossils_URL = "https://poe.ninja/api/data/itemoverview?type=Fossil&league=";
        public static string Resonators_URL = "https://poe.ninja/api/data/itemoverview?type=Resonator&league=";
        
        public static string Essences_URL = "https://poe.ninja/api/data/itemoverview?type=Essence&league=";
        public static string DivinationCards_URL = "https://poe.ninja/api/data/itemoverview?type=DivinationCard&league=";
        public static string Prophecies_URL = "https://poe.ninja/api/data/itemoverview?type=Prophecy&league=";
        
        public static string UniqueMaps_URL = "https://poe.ninja/api/data/itemoverview?type=UniqueMap&league=";
        public static string WhiteMaps_URL = "https://poe.ninja/api/data/itemoverview?type=Map&league=";
        
        public static string UniqueJewels_URL = "https://poe.ninja/api/data/itemoverview?type=UniqueJewel&league=";
        public static string UniqueFlasks_URL = "https://poe.ninja/api/data/itemoverview?type=UniqueFlask&league=";
        
        public static string UniqueWeapons_URL = "https://poe.ninja/api/data/itemoverview?type=UniqueWeapon&league=";
        public static string UniqueArmours_URL = "https://poe.ninja/api/data/itemoverview?type=UniqueArmour&league=";
        public static string UniqueAccessories_URL = "https://poe.ninja/api/data/itemoverview?type=UniqueAccessory&league=";

        // Ninja Object 16 Types
        public class NinJaAPIData
        {
            public Currency.RootObject Currency { get; set; } = new Currency.RootObject();
            public DivinationCards.RootObject DivinationCards { get; set; } = new DivinationCards.RootObject();
            public Essences.RootObject Essences { get; set; } = new Essences.RootObject();
            public Fragments.RootObject Fragments { get; set; } = new Fragments.RootObject();
            public Prophecies.RootObject Prophecies { get; set; } = new Prophecies.RootObject();
            public UniqueAccessories.RootObject UniqueAccessories { get; set; } = new UniqueAccessories.RootObject();
            public UniqueArmours.RootObject UniqueArmours { get; set; } = new UniqueArmours.RootObject();
            public UniqueFlasks.RootObject UniqueFlasks { get; set; } = new UniqueFlasks.RootObject();
            public UniqueJewels.RootObject UniqueJewels { get; set; } = new UniqueJewels.RootObject();
            public UniqueMaps.RootObject UniqueMaps { get; set; } = new UniqueMaps.RootObject();
            public UniqueWeapons.RootObject UniqueWeapons { get; set; } = new UniqueWeapons.RootObject();
            public WhiteMaps.RootObject WhiteMaps { get; set; } = new WhiteMaps.RootObject();
            public Resonators.RootObject Resonators { get; set; } = new Resonators.RootObject();
            public Fossils.RootObject Fossils { get; set; } = new Fossils.RootObject();
            public Scarab.RootObject Scarabs { get; set; } = new Scarab.RootObject();
            public Incubators.RootObject Incubators { get; set; } = new Incubators.RootObject();
        }
        #endregion

        
        public static NinJaAPIData ninjaData { get; set; }// = new NinJaAPIData();

        // DeadlyOverlay : Syndicate, and TO DO...
        public class DeadlyOverlay
        {
            public Syndicate.RootObject SyndicateDeadly { get; set; } = new Syndicate.RootObject();
        }
        public static DeadlyOverlay deadlyOverlayData { get; set; }

        // DeadlyInformation for Atlas MAP
        public class DeadlyInformation
        {
            public DeadlyAtlas.RootObject InformationDeadly { get; set; } = new DeadlyAtlas.RootObject();
            public DeadlyAtlas.RootObjectMap InformationMaps { get; set; } = new DeadlyAtlas.RootObjectMap();
            public DeadlyAtlas.RootObjectCurruncy InformationCurrency { get; set; } = new DeadlyAtlas.RootObjectCurruncy();
            public DeadlyAtlas.RootObjectDivinationCard InformationDivinationCard { get; set; } = new DeadlyAtlas.RootObjectDivinationCard();
            public DeadlyAtlas.RootObjectDelve InformationDelve { get; set; } = new DeadlyAtlas.RootObjectDelve();
            public DeadlyAtlas.RootObjectScarab InformationScarab { get; set; } = new DeadlyAtlas.RootObjectScarab();
            public DeadlyAtlas.RootObjectMapFragment InformationMapFragment { get; set; } = new DeadlyAtlas.RootObjectMapFragment();
            public DeadlyAtlas.RootObjectProphecy InformationProphecy { get; set; } = new DeadlyAtlas.RootObjectProphecy();
            public DeadlyAtlas.RootObjectUniqueMap InformationUniqueMap { get; set; } = new DeadlyAtlas.RootObjectUniqueMap();
            public DeadlyAtlas.RootObjectUnique InformationUniqueItem { get; set; } = new DeadlyAtlas.RootObjectUnique();
        }
        public static DeadlyInformation deadlyInformationData { get; set; }

        // DeadlyCrush ENG_KOR Matching Data ( Data From ggpk : aNitMotD )
        public class DeadlyENGKORMatching
        {
            public ConvertKOR.RootObject engkorMatching { get; set; } = new ConvertKOR.RootObject();
        }
        public static DeadlyENGKORMatching matchingENGKORData { get; set; }

        public LauncherForm()
        {            
            InitializeComponent();
        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {
            g_NinjaDirectory = Application.StartupPath + "\\NinjaData\\";
            // g_CurrentLeague = "Legion";

            g_ZoneInfoExpanded = true;

            Init_Controls();
            commonClass.DeleteAllFilesInFoder(g_NinjaDirectory);

            string strThisAssemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.labelCurrentVer.Text = strThisAssemblyVersion;
            this.labelServerVer.Text = strThisAssemblyVersion;
            this.labelVersionState.Text = "최신 버전을 사용하고 있습니다. (Current Version is the Newest)";
            this.labelNeedToUpdate.Text = "업데이트가 필요하지 않습니다. (No Update Nedeed)";
            
            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.Mandatory = true;
            AutoUpdater.RunUpdateAsAdmin = true;
            AutoUpdater.DownloadPath = Application.StartupPath;
            AutoUpdater.Start("https://github.com/DeadlyCrush/DeadlyTrade/releases/download/0.0.0.9/DeadlyTradeVersion.xml");

            AutoUpdater.CheckForUpdateEvent += AutoUpdater_CheckForUpdateEvent;

            //TEST TTTTTTT
            // panelWaiting.Visible = false;
            // Get_NinjaData();
        }

        private void Init_Controls()
        {
            this.Text = "Deadly Trade";
            ShowInTaskbar = true;

            // NOTIFY, TRAY
            this.notifyIconDeadlyTrade.BalloonTipTitle = "Deadly Trade";
            this.notifyIconDeadlyTrade.BalloonTipText = "Deadly Trade 가 실행중입니다. (Still Working...)";
            this.notifyIconDeadlyTrade.Text = "더블클릭하면 창이 나타납니다. (Double Click to Show)";
            this.notifyIconDeadlyTrade.BalloonTipIcon = ToolTipIcon.Info;

            // Waiting Panel : 558, 375
            this.panelWaiting.Width = 558;
            this.panelWaiting.Height = 375;

            // btnClose
            this.btnStartAddon.FlatStyle = FlatStyle.Flat;
            this.btnStartAddon.BackColor = Color.Transparent;
            this.btnStartAddon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.btnStartAddon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.btnStartAddon.FlatAppearance.BorderColor = Color.FromArgb(0, 39, 44, 56);
            this.btnStartAddon.FlatAppearance.BorderSize = 0;
            this.btnStartAddon.TabStop = false;

            // btnUpdate
            this.btnUpdate.FlatStyle = FlatStyle.Flat;
            this.btnUpdate.BackColor = Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(0, 39, 44, 56);
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.TabStop = false;

            // btnStartAddon
            this.btnStartAddon.FlatStyle = FlatStyle.Flat;
            this.btnStartAddon.BackColor = Color.Transparent;
            this.btnStartAddon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.btnStartAddon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.btnStartAddon.FlatAppearance.BorderColor = Color.FromArgb(0, 39, 44, 56);
            this.btnStartAddon.FlatAppearance.BorderSize = 0;
            this.btnStartAddon.TabStop = false;

            // PROGRESS BAR
            xuiFlatProgressBar1.MaxValue = CNT_NINJACATEGORIES*2; // Make and Update
            xuiFlatProgressBar2.MaxValue = 16;

            labelAddonStatus.Text = "Addon Data (Not loaded yet)";

            // TOOLTIP
            DeadlyToolTip.SetToolTip(this.btnMinimize, "최소화 (Minimize)");
            DeadlyToolTip.SetToolTip(this.btnClose, "닫기 (Close)");
            DeadlyToolTip.SetToolTip(this.btnUpdate, "업데이트 확인 (Check Update)");
            DeadlyToolTip.SetToolTip(this.btnStartAddon, "게임 시작을 기다리는 중입니다. (Waiting for Path Of Exile Launch Finished)");
        }

        private void ReadyToStartAddon()
        {
            btnStartAddon.Image = Properties.Resources.DeadlyTradeStartYellowButton;
            DeadlyToolTip.SetToolTip(btnStartAddon, "Deadly Trade 애드온 시작 (Start Addon)");

            g_bCanLaunchAddon = true;
        }

        private void AutoUpdater_CheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            this.btnClose.Enabled = false;
            if (args != null)
            {
                if (args.IsUpdateAvailable)
                {
                    // args.CurrentVersion means Server's Current Version.
                    this.labelServerVer.Text = args.CurrentVersion.ToString();
                    this.labelVersionState.Text = "이전 버전을 사용하고 있습니다. (Current Vrsion is not up to date)";
                    this.labelNeedToUpdate.Text = "최신 버전으로 업데이트가 필요합니다. (Update Nedeed)";

                    #region ⨌⨌ Sample Code ⨌⨌
                    /*DialogResult dialogResult;
                    if (args.Mandatory)
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"There is new version {args.CurrentVersion} available. You are using version {args.InstalledVersion}. This is required update. Press Ok to begin updating the application.", @"Update Available",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"There is new version {args.CurrentVersion} available. You are using version {
                                        args.InstalledVersion
                                    }. Do you want to update the application now?", @"Update Available",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                    }*/
                    #endregion

                    // Uncomment the following line if you want to show standard update dialog instead.
                    // AutoUpdater.ShowUpdateForm();

                    try
                    {
                        if (AutoUpdater.DownloadUpdate())
                        {
                            MSGForm frmMSG = new MSGForm();
                            frmMSG.lbMsg.Text = "업데이트가 완료되었습니다\r\n프로그램을 다시 시작합니다." +
                                "\r\n\r\nSuccessfully updated. Program will be restart.";
                            DialogResult dr = frmMSG.ShowDialog();

                            // Force Terminate Launcher.
                            if (dr == DialogResult.OK)
                                Application.Exit();
                            else
                                Application.Exit();
                        }
                    }
                    catch (Exception exception)
                    {
                        /*MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                            MessageBoxIcon.Error);*/
                        MSGForm frmMSG = new MSGForm();
                        frmMSG.lbMsg.Text = "업데이트 확인 중 오류가 발생했습니다.(An error occrred, please try again later)\r\n\r\n잠시 후 다시 시도해주세요." +
                            "\r\n\r\nERROR MESSAGE : " + exception.Message;
                        DialogResult dr = frmMSG.ShowDialog();

                        // Force Terminate Launcher.
                        if (dr == DialogResult.OK)
                            Application.Exit();
                        else
                            Application.Exit();
                    }
                }
                else
                {
                    AutoUpdater.CheckForUpdateEvent -= AutoUpdater_CheckForUpdateEvent;
                    g_bCanLaunchAddon = false;

                    // args.CurrentVersion means Server's Current Version.
                    this.labelCurrentVer.Text = args.InstalledVersion.ToString();
                    this.labelServerVer.Text = args.CurrentVersion.ToString();
                    this.labelVersionState.Text = "최신 버전을 사용하고 있습니다. (Current Version is the Newest)";
                    this.labelNeedToUpdate.Text = "업데이트가 필요하지 않습니다. (No Update Nedeed)";

                    Thread.Sleep(500);
                    this.panelWaiting.Visible = false;


                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));

                    // Get Addon Data & Pesonal Setting ( From My Games - Path of Exile )               
                    String strPathPOEConifg = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    strPathPOEConifg = strPathPOEConifg + "\\My Games\\Path of Exile\\production_Config.ini";
                    IniParser parser = new IniParser(strPathPOEConifg);

                    try
                    {
                        string strLanguage = parser.GetSetting("LANGUAGE", "language");
                        if (strLanguage.Equals("ko-KR", StringComparison.OrdinalIgnoreCase))
                            g_strUILang = "KOR";
                        else if (strLanguage.Equals("en", StringComparison.OrdinalIgnoreCase))
                            g_strUILang = "ENG";
                        else
                            g_strUILang = "UNKNOWN";

                        // STEP #1 Done.
                        xuiFlatProgressBar2.Value = 1;
                        labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));

                        string strLocalChat = parser.GetSetting("UI", "show_local_chat");
                        if (strLocalChat.Equals("true", StringComparison.OrdinalIgnoreCase))
                            g_bShowLocalChat = true;
                        else
                            g_bShowLocalChat = false;

                        // STEP #2 Done.
                        xuiFlatProgressBar2.Value = 2;
                        labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));

                        if (g_strUILang == "UNKNOWN")
                        {
                            MSGForm frmMSG = new MSGForm();
                            frmMSG.btmConfirm.Visible = false;
                            frmMSG.btnENG.Visible = true;
                            frmMSG.btnKOR.Visible = true;
                            frmMSG.lbMsg.Text = "UI 언어 설정을 확인할 수 없습니다.\r\n(Can't find POE UI Configuration.)" +
                                "\r\n\r\n어떤 언어의 UI를 사용하고 계신가요?\r\nWhat is your UI Languge in POE?";
                            DialogResult dr = frmMSG.ShowDialog();
                            if (dr == DialogResult.Yes)
                                g_strUILang = "KOR";
                            else
                                g_strUILang = "ENG";
                        }

                        // FLASK KEYS
                        string strFlask1 = parser.GetSetting("ACTION_KEYS", "use_flask_in_slot1");
                        string strFlask2 = parser.GetSetting("ACTION_KEYS", "use_flask_in_slot2");
                        string strFlask3 = parser.GetSetting("ACTION_KEYS", "use_flask_in_slot3");
                        string strFlask4 = parser.GetSetting("ACTION_KEYS", "use_flask_in_slot4");
                        string strFlask5 = parser.GetSetting("ACTION_KEYS", "use_flask_in_slot5");
                        g_Flask1 = Convert.ToInt32(strFlask1);
                        g_Flask2 = Convert.ToInt32(strFlask2);
                        g_Flask3 = Convert.ToInt32(strFlask3);
                        g_Flask4 = Convert.ToInt32(strFlask4);
                        g_Flask5 = Convert.ToInt32(strFlask5);

                        resolution_height = Convert.ToInt32(parser.GetSetting("DISPLAY", "resolution_height"));
                        resolution_width = Convert.ToInt32(parser.GetSetting("DISPLAY", "resolution_width"));
                    }
                    catch
                    {
                        g_strUILang = "UNKNOWN";
                        g_bShowLocalChat = false;

                        MSGForm frmMSG = new MSGForm();
                        frmMSG.lbMsg.Text = "게임 설정 정보를 확인할 수 없습니다.\r\n(Can't read POE Configuration.)" +
                            "\r\n\r\n게임 실행 후, UI언어와 지역채팅 활성화를 확인하고 게임 옵션을 저장 후 다시 시도해주세요.\r\n" +
                            "(Please check POE UI Setting and Local Chat Enabled & Save Game Options. And Try again Please.)";
                        DialogResult dr = frmMSG.ShowDialog();

                        // Force Terminate Launcher.
                        if (dr == DialogResult.OK)
                            Application.Exit();
                        else
                            Application.Exit();
                    }                    

                    // STEP #3 Done.
                    xuiFlatProgressBar2.Value = 3;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));

                    Get_NinjaData();
                }
            }
            else
            {
                /*MessageBox.Show(
                        @"There is a problem reaching update server please check your internet connection and try again later.",
                        @"Update check failed", MessageBoxButtons.OK, MessageBoxIcon.Error);*/
                MSGForm frmMSG = new MSGForm();
                frmMSG.lbMsg.Text = "업데이트 서버에 연결할 수 없습니다. (There is a problem reaching update server)" +
                    "\r\n\r\n인터넷 연결을 확인하신 후 다시 시도해주세요. (Please check your internet connection and try again later)";
                DialogResult dr = frmMSG.ShowDialog();

                // Force Terminate Launcher.
                if (dr == DialogResult.OK)
                    Application.Exit();
                else
                    Application.Exit();
            }
            this.btnClose.Enabled = true;
        }

        private void Get_NinjaData()
        {
            Thread.Sleep(300);
            string strINIPath = String.Format("{0}\\{1}", Application.StartupPath, "ConfigPath.ini");

            if (resolution_width < 1920 && resolution_height < 1080)
            {
                strINIPath = String.Format("{0}\\{1}", Application.StartupPath, "ConfigPath_1600_1024.ini");
                if (resolution_width < 1600 && resolution_height < 1024)
                    strINIPath = String.Format("{0}\\{1}", Application.StartupPath, "ConfigPath_1280_768.ini");
            }
            IniParser parser = new IniParser(strINIPath);

            try
            {
                string strUserChoideLeague = parser.GetSetting("LEAGUE", "USERCHOICE");
                int nUserChoice = Convert.ToInt32(strUserChoideLeague);

                LEAGUE_STRING enumUerChoice = LEAGUE_STRING.LEAGUE_LEGION;
                switch (nUserChoice)
                {
                    case 0:
                        enumUerChoice = LEAGUE_STRING.LEAGUE_LEGION;
                        break;
                    case 1:
                        enumUerChoice = LEAGUE_STRING.LEAGUE_STANDARD;
                        break;
                    case 2:
                        enumUerChoice = LEAGUE_STRING.LEAGUE_HDCORE_LEGION;
                        break;
                    case 3:
                        enumUerChoice = LEAGUE_STRING.LEAGUE_HDCORE_STANDARD;
                        break;
                    default:
                        enumUerChoice = LEAGUE_STRING.LEAGUE_LEGION;
                        break;
                }

                g_CurrentLeague = enumUerChoice.ToDescriptionString();
                labelUserLeague.Text = String.Format("최근 시세를 검색한 리그는 '{0}'. ( Last checked currency league is '{1}' )", g_CurrentLeague, g_CurrentLeague);

                g_FlaskTime1 = parser.GetSetting("MISC", "FLASKTIME1");
                g_FlaskTime2 = parser.GetSetting("MISC", "FLASKTIME2");
                g_FlaskTime3 = parser.GetSetting("MISC", "FLASKTIME3");
                g_FlaskTime4 = parser.GetSetting("MISC", "FLASKTIME4");
                g_FlaskTime5 = parser.GetSetting("MISC", "FLASKTIME5");

                if (parser.GetSetting("MISC", "TOGGLE1ON") == "TRUE")
                    g_bToggle1 = true;
                else
                    g_bToggle1 = false;
                if (parser.GetSetting("MISC", "TOGGLE2ON") == "TRUE")
                    g_bToggle2 = true;
                else
                    g_bToggle2 = false;
                if (parser.GetSetting("MISC", "TOGGLE3ON") == "TRUE")
                    g_bToggle3 = true;
                else
                    g_bToggle3 = false;
                if (parser.GetSetting("MISC", "TOGGLE4ON") == "TRUE")
                    g_bToggle4 = true;
                else
                    g_bToggle4 = false;
                if (parser.GetSetting("MISC", "TOGGLE5ON") == "TRUE")
                    g_bToggle5 = true;
                else
                    g_bToggle5 = false;

                g_strMyNickName = parser.GetSetting("CHARACTER", "MYNICK");
                g_strTRWait = parser.GetSetting("CHARACTER", "WAIT");
                g_strTRSold = parser.GetSetting("CHARACTER", "SOLD");
                g_strTRThanks = parser.GetSetting("CHARACTER", "THANKS");
                g_strTRResend = parser.GetSetting("CHARACTER", "RESEND");
                g_strTRAutoKick = parser.GetSetting("CHARACTER", "AUTOKICK");

                string strGridWidth = parser.GetSetting("LOCATIONGRID", "RIGHT");
                string strGridHeight = parser.GetSetting("LOCATIONGRID", "BOTTOM");
                g_nGridWidth = Convert.ToInt32(parser.GetSetting("LOCATIONGRID", "RIGHT"));
                g_nGridHeight = Convert.ToInt32(parser.GetSetting("LOCATIONGRID", "BOTTOM"));

                // push pin LOCK, UNLOCK
                string strTemp = parser.GetSetting("MISC", "PUSHPINLOCK");
                if (strTemp == "N")
                    g_pinLOCK = false;
                else
                    g_pinLOCK = true;
            }
            catch
            {
                MSGForm frmMSG = new MSGForm();
                frmMSG.lbMsg.Text = "환경 파일이 손상되었거나 삭제되었습니다.\r\n프로그램을 종료하고 다시시도해주세요.\r\n\r\n" +
                    "Can't read conguration. File seems to be corrupt or delete.\r\nPlease Try again.";
                DialogResult dr = frmMSG.ShowDialog();

                // Force Terminate Launcher.
                if (dr == DialogResult.OK)
                    Application.Exit();
                else
                    Application.Exit();
            }

            launcherTimer.Start();
            frmNinja = new NinjaForm();
            frmNinja.GetNinJaDataSync();
        }

        private void LauncherTimer_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            // int nCnt = commonClass.GetFileCountFromFolder(g_NinjaDirectory, false);
            labelNINJASTATUS.Text = "POE.NINJA 데이터 ("+ g_NinjaUpdatedTime + ")";

            xuiFlatProgressBar1.Value = g_NinjaFileMakeAndUpdateCNT;
            if (g_NinjaFileMakeAndUpdateCNT >= CNT_NINJACATEGORIES*2)
            {
                launcherTimer.Stop();
                Thread.Sleep(100);
                frmNinja.Close();

                Get_DeadlyOverlayData(); // STEP #4~14 Done.

                Get_deadlyInformationData();

                // STEP #15 Done.
                xuiFlatProgressBar2.Value = 15;
                labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));

                Get_matchingENGKORData();



                






                labelPOEAddonNotice.Visible = true;
                labelPOEAdddonNotifyText.Visible = true;
                labelPOERealPath.Visible = true;

                // STEP #16 Done.
                xuiFlatProgressBar2.Value = 16;
                labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));

                timerDetect.Start();
            }
        }

        private void TimerDetect_Tick(object sender, EventArgs e)
        {
            // TTTTT
            // Show Start Button
            //ReadyToStartAddon();
            //return;

            Thread.Sleep(100);
            IntPtr handlePOE = IntPtr.Zero;
            handlePOE = FindWindow("POEWindowClass", "Path of Exile"); // ClassName = POEWindowClass
            if (handlePOE!= IntPtr.Zero)
            {
                timerDetect.Stop();
                Thread.Sleep(100);

                g_POELogPath = GetPathFromHandle(handlePOE);

                bool containsKG = Regex.IsMatch(g_POELogPath, Regex.Escape("KG"), RegexOptions.IgnoreCase);

                if (containsKG)
                {
                    g_POELogFileName = "KakaoClient.txt";
                    labelReady.Text = "POE [KAKAO Client] Readly to";

                    labelClient.Text = "CLIENT : KAKAO";
                }
                else
                {
                    g_POELogFileName = "Client.txt";
                    labelReady.Text = "POE [GGG Client] Readly to";

                    labelClient.Text = "CLIENT : GGG";
                }

                if (g_strUILang == "KOR")
                    pictureBoxKOREA.BackgroundImage = Properties.Resources.flag_korea;
                else if (g_strUILang == "ENG")
                    pictureBoxKOREA.BackgroundImage = Properties.Resources.flag_united_kingdom;
                else
                {
                    if(containsKG)
                    {
                        g_strUILang = "KOR";
                        pictureBoxKOREA.BackgroundImage = Properties.Resources.flag_korea;
                    }
                    else
                    {
                        g_strUILang = "ENG";
                        pictureBoxKOREA.BackgroundImage = Properties.Resources.flag_united_kingdom;
                    }
                }                

                labelUI.Text = String.Format("Your UI : {0}", g_strUILang);
                labelClient.Visible = true;
                labelUI.Visible = true;
                pictureBoxKOREA.Visible = true;

                g_POELogPath = Path.GetDirectoryName(g_POELogPath);               
                
                labelReady.Visible = true;
                labelPOEAddonNotice.Text = "게임이 실행중입니다. Path of Exile Detected.";

                g_POELogPath = String.Format("{0}\\Logs\\{1}", g_POELogPath, g_POELogFileName);
                labelPOERealPath.Text = g_POELogPath;

                // TTTTTTT // TTTTTTTg_POELogPath = @"D:\DAUM GAMES\PATH OF EXILE\LOGS\TESTCLIENT.TXT"; 

                string strINIPath = String.Format("{0}\\{1}", Application.StartupPath, "ConfigPath.ini");

                if (resolution_width < 1920 && resolution_height < 1080)
                {
                    strINIPath = String.Format("{0}\\{1}", Application.StartupPath, "ConfigPath_1600_1024.ini");
                    if (resolution_width < 1600 && resolution_height < 1024)
                        strINIPath = String.Format("{0}\\{1}", Application.StartupPath, "ConfigPath_1280_768.ini");
                }
                IniParser parser = new IniParser(strINIPath);

                parser.AddSetting("CHARACTER", "MYNICK", g_strMyNickName);
                parser.AddSetting("CHARACTER", "WAIT", g_strTRWait);
                parser.AddSetting("CHARACTER", "SOLD", g_strTRSold);
                parser.AddSetting("CHARACTER", "THANKS", g_strTRThanks);
                parser.AddSetting("CHARACTER", "RESEND", g_strTRResend);
                parser.AddSetting("CHARACTER", "AUTOKICK", g_strTRAutoKick);

                parser.AddSetting("DIRECTIONHELPER", "POELOGPATH", g_POELogPath);
                parser.AddSetting("MISC", "PUSHPINLOCK", g_pinLOCK ? "Y" : "N");

                parser.AddSetting("LOCATIONGRID", "RIGHT", g_nGridWidth.ToString());
                parser.AddSetting("LOCATIONGRID", "BOTTOM", g_nGridHeight.ToString());

                parser.SaveSettings();

                SetForegroundWindow(handlePOE);

                // Set Foreground
                /*this.WindowState = FormWindowState.Minimized;
                this.Show();
                this.WindowState = FormWindowState.Normal;*/
                this.BringToFront();

                // Show Start Button
                ReadyToStartAddon(); 
            }
        }

        private void Get_DeadlyOverlayData()
        {
            var tmpData = new DeadlyOverlay();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            try
            {
                using (var r = new StreamReader(Application.StartupPath + "\\SyndicateMember\\SyndicateInform.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.SyndicateDeadly = JsonConvert.DeserializeObject<Syndicate.RootObject>(json, settings);
                }
            }
            catch
            {
                MSGForm frmMSG = new MSGForm();
                frmMSG.lbMsg.Text = "신디케이트 정보를 읽을 수 없습니다..\r\n(Can't read Syndicate Information.)" +
                    "\r\n\r\n설치 파일을 확인 후 다시 시도해주세요.\r\n" +
                    "(Please check your addon installation and Try again.)";
                DialogResult dr = frmMSG.ShowDialog();

                // Force Terminate Launcher.
                if (dr == DialogResult.OK)
                    Application.Exit();
                else
                    Application.Exit();
            }

            deadlyOverlayData = tmpData;
        }

        private void Get_deadlyInformationData()
        {
            var tmpData = new DeadlyInformation();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            try
            {
                using (var r = new StreamReader(Application.StartupPath + "\\AtlasDrop\\ZoneInform.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.InformationDeadly = JsonConvert.DeserializeObject<DeadlyAtlas.RootObject>(json, settings);

                    xuiFlatProgressBar2.Value = 5;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                }

                using (var r = new StreamReader(Application.StartupPath + "\\AtlasDrop\\Maps.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.InformationMaps = JsonConvert.DeserializeObject<DeadlyAtlas.RootObjectMap>(json, settings);

                    xuiFlatProgressBar2.Value = 6;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                }

                using (var r = new StreamReader(Application.StartupPath + "\\AtlasDrop\\Currency.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.InformationCurrency = JsonConvert.DeserializeObject<DeadlyAtlas.RootObjectCurruncy>(json, settings);

                    xuiFlatProgressBar2.Value = 7;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                }

                using (var r = new StreamReader(Application.StartupPath + "\\AtlasDrop\\DivinationCards.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.InformationDivinationCard = JsonConvert.DeserializeObject<DeadlyAtlas.RootObjectDivinationCard>(json, settings);

                    xuiFlatProgressBar2.Value = 8;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                }

                using (var r = new StreamReader(Application.StartupPath + "\\AtlasDrop\\Delve.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.InformationDelve = JsonConvert.DeserializeObject<DeadlyAtlas.RootObjectDelve>(json, settings);

                    xuiFlatProgressBar2.Value = 9;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                }

                using (var r = new StreamReader(Application.StartupPath + "\\AtlasDrop\\Scarabs.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.InformationScarab = JsonConvert.DeserializeObject<DeadlyAtlas.RootObjectScarab>(json, settings);

                    xuiFlatProgressBar2.Value = 10;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                }

                using (var r = new StreamReader(Application.StartupPath + "\\AtlasDrop\\MapFragments.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.InformationMapFragment = JsonConvert.DeserializeObject<DeadlyAtlas.RootObjectMapFragment>(json, settings);

                    xuiFlatProgressBar2.Value = 11;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                }

                using (var r = new StreamReader(Application.StartupPath + "\\AtlasDrop\\Prophecies.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.InformationProphecy = JsonConvert.DeserializeObject<DeadlyAtlas.RootObjectProphecy>(json, settings);

                    xuiFlatProgressBar2.Value = 12;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                }

                using (var r = new StreamReader(Application.StartupPath + "\\AtlasDrop\\UniqueMaps.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.InformationUniqueMap = JsonConvert.DeserializeObject<DeadlyAtlas.RootObjectUniqueMap>(json, settings);

                    xuiFlatProgressBar2.Value = 13;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                }

                using (var r = new StreamReader(Application.StartupPath + "\\AtlasDrop\\Uniques.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.InformationUniqueItem = JsonConvert.DeserializeObject<DeadlyAtlas.RootObjectUnique>(json, settings);

                    xuiFlatProgressBar2.Value = 14;
                    labelAddonStatus.Text = String.Format("Addon Data ({0})", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
                }
            }
            catch
            {
                MSGForm frmMSG = new MSGForm();
                frmMSG.lbMsg.Text = "매핑 정보를 읽을 수 없습니다..\r\n(Can't read Mapping Information.)" +
                    "\r\n\r\n설치 파일을 확인 후 다시 시도해주세요.\r\n" +
                    "(Please check your addon installation and Try again.)";
                DialogResult dr = frmMSG.ShowDialog();

                // Force Terminate Launcher.
                if (dr == DialogResult.OK)
                    Application.Exit();
                else
                    Application.Exit();
            }

            deadlyInformationData = tmpData;
        }

        public void Get_matchingENGKORData()
        {
            var tmpData = new DeadlyENGKORMatching();

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            try
            {
                using (var r = new StreamReader(Application.StartupPath + "\\DeadlyInform\\ENGmatchKOR.json"))
                {
                    var json = r.ReadToEnd();
                    tmpData.engkorMatching = JsonConvert.DeserializeObject<ConvertKOR.RootObject>(json, settings);
                }
            }
            catch
            {
                MSGForm frmMSG = new MSGForm();
                frmMSG.lbMsg.Text = "번역 정보를 읽을 수 없습니다..\r\n(Can't read Translation Information.)" +
                    "\r\n\r\n설치 파일을 확인 후 다시 시도해주세요.\r\n" +
                    "(Please check your addon installation and Try again.)";
                DialogResult dr = frmMSG.ShowDialog();

                // Force Terminate Launcher.
                if (dr == DialogResult.OK)
                    Application.Exit();
                else
                    Application.Exit();
            }

            matchingENGKORData = tmpData;
        }

        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            nMoving = 1;
            nMovePosX = e.X;
            nMovePosY = e.Y;
        }

        private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (nMoving == 1)
            {
                this.SetDesktopLocation(MousePosition.X - nMovePosX, MousePosition.Y - nMovePosY);
            }
        }

        private void PictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            nMoving = 0;
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            this.panelWaiting.Visible = true;

            AutoUpdater.ShowSkipButton = false;
            AutoUpdater.ShowRemindLaterButton = false;
            AutoUpdater.Mandatory = true;
            AutoUpdater.RunUpdateAsAdmin = true;
            AutoUpdater.DownloadPath = Application.StartupPath;
            AutoUpdater.Start("https://github.com/DeadlyCrush/DeadlyTrade/releases/download/0.1.0.1/DeadlyTradeVersion.xml");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LauncherForm_Resize(object sender, EventArgs e)
        {
            if(FormWindowState.Minimized == this.WindowState)
            {
                notifyIconDeadlyTrade.Visible = true;
                notifyIconDeadlyTrade.ShowBalloonTip(500);
                this.Hide();
                ShowInTaskbar = false;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconDeadlyTrade.Visible = false;
            }
        }

        #region ⨌⨌ NotifyIcon : Tray ⨌⨌
        private void NotifyIconDeadlyTrade_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        #endregion

        private void BtnStartAddon_Click(object sender, EventArgs e)
        {
            if (!g_bCanLaunchAddon)
            {
                MSGForm frmMSG = new MSGForm();
                frmMSG.lbMsg.Text = "게임이 실행 되기를 기다리고 있습니다.\r\n(Waiting for 'POE' Started)";
                frmMSG.ShowDialog();
                return;
            }

            if (g_bAddonLaunched)
            {
                MSGForm frmMSG = new MSGForm();
                frmMSG.lbMsg.Text = "Deadly Trade가 이미 실행중입니다.\r\n(Deadly Trade is already running)";
                frmMSG.ShowDialog();
                return;
            }

            if(!g_bShowLocalChat)
            {
                MSGForm frmMSG = new MSGForm();
                frmMSG.lbMsg.Text = "지역 채팅 정보가 필요합니다.\r\n지역 채팅을 켜주세요.\r\n\r\n" +
                    "Addon use LOCAL CHAT Information.\r\nPlease turn on LOCAL CHAT.";
                frmMSG.ShowDialog();
            }

            Start_ControlForm();
        }

        private void Start_ControlForm()
        {
            g_bAddonLaunched = true;

            IntPtr handlePOE = IntPtr.Zero;
            handlePOE = FindWindow("POEWindowClass", "Path of Exile"); // ClassName = POEWindowClass
            SetForegroundWindow(handlePOE);

            frmMainControl = new ControlForm();
            frmMainControl.ShowIcon = false;
            frmMainControl.ShowInTaskbar = false;
            //frmMainControl.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frmMainControl.Show();

            // Load_MiscForms();

            timerOutFocus.Start();
            WindowState = FormWindowState.Minimized;
            Hide();
        }               

        #region ⨌⨌ FormClosed : Dispose All ⨌⨌
        private void LauncherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerOutFocus.Stop();

            if (frmNinja != null) frmNinja.Dispose();
            if (frmMainControl != null) frmMainControl.Dispose();
            if (commonClass != null) commonClass = null;

            if (ninjaData != null) ninjaData = null;
            if (deadlyOverlayData != null) deadlyOverlayData = null;
        }
        #endregion

        private void TimerOutFocus_Tick(object sender, EventArgs e)
        {
            uint processID = 0;
            IntPtr hWnd = GetForegroundWindow();
            int threadID = GetWindowThreadProcessId(hWnd, out processID);
            Process fgProc = Process.GetProcessById(Convert.ToInt32(processID));

            const int nChars = 256;
            StringBuilder strWindowTitle = new StringBuilder(nChars);

            if (GetWindowText(hWnd, strWindowTitle, nChars) > 0)
            {
                // Debug.WriteLine(strWindowTitle.ToString());
                if (fgProc.ProcessName == "DeadlyTrade" || strWindowTitle.ToString() == "Path of Exile")
                {
                    foreach (Form childfrm in Application.OpenForms)
                        childfrm.Show();

                    g_FocusLosing = false;
                }
                else
                {
                    // Hide All DeadlyTrade Forms.
                    foreach (Form childfrm in Application.OpenForms)
                    {
                        childfrm.Hide();
                    }

                    g_FocusLosing = true;
                }
            }
        }
    }
}
