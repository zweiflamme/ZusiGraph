using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection; //for usage of assembly data
using System.Diagnostics; // usage of stopwatch
using Zusi_Datenausgabe; //TODO: v1.0.0
using System.Runtime.InteropServices; //to hand over the focus to Zusi main window
using System.Media; //for sound playback
using System.Windows.Forms.DataVisualization.Charting;

namespace ZusiGraph
{
    public partial class CMainWindow : Form
    {
        

        // We do want to have a ZusiTcpConn object, so here's the declaration
        private ZusiTcpConn MyTCPConnection;

        // Initalize a new stopwatch
        Stopwatch stopwatch = new Stopwatch();
           
        //Declare external methods
        //for usage of the 'focus back to Zusi' feature
        [DllImport("User32.dll")]
        static extern long SetForegroundWindow(int hwnd);
        
        [DllImport("user32.dll")]
        extern static Boolean SetForegroundWindow(IntPtr Fenster);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        extern static IntPtr SetActiveWindow(IntPtr Fenster);


        public CMainWindow()
        {
            InitializeComponent();

            //we need to define a new connection to the TCP server:
            MyTCPConnection = new ZusiTcpConn(
             "ZusiGraph - v" + Assembly.GetExecutingAssembly().GetName().Version.ToString(), // Name and version, showing up in server's list
             ClientPriority.Low);

            MyTCPConnection.ErrorReceived += TCPConnection_ErrorReceived;
            MyTCPConnection.FloatReceived += TCPConnection_FloatReceived;            
            MyTCPConnection.BoolReceived += TCPConnection_BoolReceived;
            //MyTCPConnection.IntReceived += TCPConnection_IntReceived;
            //MyTCPConnection.StringReceived += TCPConnection_StringReceived;
            MyTCPConnection.DateTimeReceived += TCPConnection_DateTimeReceived;
            //MyTCPConnection.BrakeConfigReceived += TCPConnection_BrakeConfigReceived;
            MyTCPConnection.DoorsReceived += TCPConnection_DoorsReceived;
            //MyTCPConnection.PZBReceived += TCPConnection_PZBReceived;


            #region RequestData
            MyTCPConnection.RequestData(2561); // "Geschwindigkeit"
            MyTCPConnection.RequestData(2660); // "Aktuelle Höchstgeschwindigkeit"
            MyTCPConnection.RequestData(2578); // "AFB Soll-Geschwindigkeit"
            MyTCPConnection.RequestData(2636); // "LZB Soll-Geschwindigkeit"
            MyTCPConnection.RequestData(2573); // "LZB Ziel-Geschwindigkeit"
            MyTCPConnection.RequestData(2635); // "LM LZB-Zielweg (ab 0)"   

            MyTCPConnection.RequestData(2654); // "Bremshundertstel"
            MyTCPConnection.RequestData(2562); // "Druck Hauptluftleitung"
            MyTCPConnection.RequestData(2563); // "Druck Bremszylinder"
            MyTCPConnection.RequestData(2564); // "Druck Hauptluftbehälter"
            MyTCPConnection.RequestData(2579); // "Druck Hilfsluftbehälter"

            MyTCPConnection.RequestData(2645); // "Strecken-Km in Metern"

            MyTCPConnection.RequestData(2611); // "Schalter Fahrstufen"
            MyTCPConnection.RequestData(2576); // "Fahrstufe"
            MyTCPConnection.RequestData(2615); // "Schalter AFB-Geschwindigkeit"
            MyTCPConnection.RequestData(2612); // "Schalter Führerbremsventil"
            //###//
            MyTCPConnection.RequestData(2599); // "LM Schleudern"     
            MyTCPConnection.RequestData(2596); // "LM Sifa"
            
            MyTCPConnection.RequestData(2616); // "Schalter AFB ein/aus"
            MyTCPConnection.RequestData(2621); // "Schalter Sifa"

            MyTCPConnection.RequestData(2648); // "Reisezug" 
            MyTCPConnection.RequestData(2647); // "Autopilot"

            //###PZB-90###//
            MyTCPConnection.RequestData(2583); // "LM PZB Zugart U"
            MyTCPConnection.RequestData(2584); // "LM PZB Zugart M"
            MyTCPConnection.RequestData(2585); // "LM PZB Zugart O"
            MyTCPConnection.RequestData(2580); // "LM PZB 1000Hz"
            MyTCPConnection.RequestData(2581); // "LM PZB 500Hz"
            MyTCPConnection.RequestData(2582); // "LM PZB Befehl"
            //###//

            //###LZB###//
            MyTCPConnection.RequestData(2587); // "LM LZB G"
            MyTCPConnection.RequestData(2590); // "LM LZB Ende"
            MyTCPConnection.RequestData(2592); // "LM LZB B"
            MyTCPConnection.RequestData(2593); // "LM LZB S "
            MyTCPConnection.RequestData(2594); // "LM LZB Ü"
            MyTCPConnection.RequestData(2595); // "LM LZB Prüfen"
            //###//

            //###//
            MyTCPConnection.RequestData(2610); // "LM Uhrzeit (digital)"
            
            
            MyTCPConnection.RequestData(2646); // "Türen"

            
            
            

            ////TODO MyTCPConnection.RequestData(2656); // "Zugdatei"
            //TODO: is this needed? MyTCPConnection.RequestData(2574); // "LZB/AFB Soll-Geschwindigkeit"
            //TODO: is this needed? MyTCPConnection.RequestData(2615); // "Schalter AFB-Geschwindigkeit"
            #endregion 

        }

        public void PlayRRSound()
        {
            try
            {
                SoundPlayer rrSound = new SoundPlayer(@".\resources\rr_meep.wav");
                rrSound.Play();
                //TODO: DEBUG: rrSound needs to be played only ONCE when railrunner i done
                rrSoundplayed = true;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Sound kann nicht wiedergegeben werden - Datei nicht gefunden!");
            }
        }

        public void Connect() // here we are going to try connecting to the TCP server
        {
            String server = Convert.ToString(tbServer.Text);
            int port = Convert.ToInt16(tbPort.Text);
            
                // If we're currently disconnected...
                if (MyTCPConnection.ConnectionState == Zusi_Datenausgabe.ConnectionState.Disconnected)
                {
                    // ... try to ... 
                    try
                    {
                        // ... establish a connection using the hostname and port number from the main window.
                        MyTCPConnection.Connect(server, port);
                        setStatus("Warte");
                    }

                    // If something goes wrong...
                    catch (ZusiTcpException ex)
                    {
                        // ... show the user what the connection object has to say.
                        MessageBox.Show(String.Format("Verbindungsfehler: {0}", ex.Message));
                        MyTCPConnection.Disconnnect();
                        setStatus("Getrennt");
                    }
                }

                // If we're currently connected or the connection fell into an error state...
                else
                {
                    // ... reset the connection by explicitly calling Disconnect();
                    MyTCPConnection.Disconnnect();
                    setStatus("Getrennt");
                }            
        }

        #region Setting Of Variables

        //TODO: Load with preferences
        //Here are the default colors for day- and nightmode
        Color labeldaycolor = Color.Black;
        Color paneldaycolor = Color.FromName("Control");
        Color buttondaycolor = Color.FromName("Control");
        Color formdaycolor = Color.FromName("Control");
        Color textboxdaycolor = Color.FromName("Window");

        Color labelnightcolor = Color.WhiteSmoke;
        Color panelnightcolor = Color.FromName("ControlDark");
        Color buttonnightcolor = Color.FromName("ControlDark");
        Color formnightcolor = Color.FromName("ControlDark");
        Color textboxnightcolor = Color.LightGray;      

        //Streckenmeter: User can choose between display in meters or kilometers
        //if factor == 1000 kilometers will be displayed, if factor == 1 meters will be displayed
        int StreckenmeterDarstfaktor = 1000;

        //default values fur user-sizeable form elements
        double labelsifadefaultwidth = 114;
        double labelsifadefaultheight = 51;
        double labelflagdefaultwidth = 114;
        double labelflagdefaultheight = 19;

        //default values for setting a neutral position of Fahr-/Bremsschalter (Kombihebel)
        //TODO: Is there a better solution?
        int fahrschalterneutral = 0;

        //TODO: check for every variable if it's still needed
        double geschwindigkeit;
        double geschwindigkeitMaxZul;
        public bool abbruch; //TODO: check if still needed
        double vorgabe, entfernung;
        double streckenmeter = 0;
        bool hasMoved = false; //has the train moved?
        double brh;
        double maxVerz = 1; //maximum deceleration
        bool scharf = false; //has the train been stopped sharply?
        bool gebremst = false; //has been braked after acceleration? //TODO: check if still needed
        bool verbunden = false; //connection state of TCP-Server <-> Zusi (when data from Zusi has been received)
        double vAlt = 0, vNeu = 0, deltaV; //determination of acceleration / deceleration
        double vTemp = 0;
        double vReached = 0; //setting a maximum reached speed vReached //TODO: check if still needed
        public bool vMaxErreicht = false; //has a specific speed been reached yet? //TODO: check if still needed
        bool afbistein = false; //reflects the AFB switch status on/off
        public bool debugging = false; //if user has opened the debug panel debugging will be true
        public bool alwaysShowSettings = false; //for determining if the settings panel shall auto hide: has button been clicked?
        bool nightmode = false; //for letting the user choose between two different color sets
        //TODO: maybe it makes sense to determine day- and nightmode automatically when receiving daytime from Zusi
        bool reisezug; //if not true door label will be "Güterzug"
        //DEBUG
        //String zugdateiOld = "";
        //String zugdatei = "";
        //TEST
        bool autopilot = false; //is being checked in intervals to always display label lblFlag "Autopilot ein" when on
        double vmps = 0; // speed in meters per second
        double railrunner = 0; // meters elapsed
        bool rrrunning = false; //is railrunner running?
        //TEST TODO: declare local instead of global
        decimal oldlblsizevaluegrunddaten = 0;
        decimal oldlblsizevaluebremsen = 0;
        decimal oldlblsizevalueafblzb = 0;
        double afbvorwahl = 0.0; // storing value of AFB Schalter * preselected facor / preselected speed
        double afbschalter = 0.0; // storing value of AFB Schalter
        bool rrSoundplayed = false; //has Railrunner sound been played?
        double stunde, minute, sekunde; //TODO: if DLL 1.1.6 is used, this will be obsolete
        double druckhbl, druckhlb, hlldruck;
        double schaltersifa; // if pressed twice RR is activated
        bool settingsAreSeparated = false; // true if settings are shown on a separate form (frmSettings)
        bool lzbIsActive = false; // is LZB active (LM LZB Ü)?
        double afbsoll, lzbsoll; //TEST

        String graphMode = "Aufzeichnung"; //TODO
        bool graphIsRunning = false;
        bool graphIsSeparated = false;
        bool showseparatedgraph = false;

        double streckenmeterOld = 0.0;
        double deltaStreckenmeter = 0.0;

        //TEST for graph
        String graphStreckenKm = "";
        double graphStreckenKmDouble = 0.0;
        bool kmSprung = false;

        //TODO: TEST: is this the best place?
        SettingsForm frmSettings = new SettingsForm();
        GraphForm frmGraph = new GraphForm();
        
    

        #endregion

        private void CMainWindow_Load(object sender, EventArgs e) //on loading of the main window...
        {
            //TEST
            //pre-draw on chart so that chart grid is visible
            //TODO: find a better way
            //graph1.Series["geschw"].Points.AddY(0);
            //graph1.Series["hlldruck"].Points.AddY(0);
            
            //TEST TODO
            #region Ensure loaded settings apply
            //make sure every label and panel is visible according to checkboxes:           
            //TODO

            

            //make sure Sifa label has the proper size:
            ResizeSifa();
            

            //make sure radio buttons are in their correct state
             //second rb is bound to settings
         
            rbUnitm.Checked = !rbUnitkm.Checked;
            rbUnitmps.Checked = !rbUnitkph.Checked;

            //make sure checkboxes that exclude each other are properly checked
            //TODO

            #endregion            

            if (cbTopmost.Checked == true)
                this.TopMost = true;
            
            //TEST DEBUG
            //if separate settings window will be used, show it
            //TODO ShowSeparateSettingsWindow(); //includes check if cbSeparateSettings is checked

            //TEST
            //moving pnlRight a bit
            //TODO: move according to pnlLeft size
            this.pnlRight.Location = new Point(pnlLeft.Location.X + pnlLeft.Width + 10, pnlLeft.Location.Y);

            //TEST
            //setting form title directly from the assembly information.
            this.Text = this.Text + "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            
            //showing 'System' tab first so that the user is able to establish a connection to the TCP server
            tabEinstellungen.SelectTab("tabSystem");   

            //if a narrow tab page is selected (such as tabSystem)...
            if (tabEinstellungen.SelectedTab == tabEinstellungen.TabPages["tabSystem"])
            {
                tabEinstellungen.Width = 220;
            }

            //adding a global function for all checkboxes, main reason is to determine if user has clicked
            //a checkbox, if so it's being checked if Zusi shall have the window focus back
            //TODO: find a better and more elegant way to detect user interaction with ALL controls on the form

            //pnlBremsen.Controls.Remove(numSizeBremsen);
            foreach (CheckBox c in pnlBremsen.Controls)
            {
                c.CheckedChanged += new System.EventHandler(this.Control_CheckedChanged);
            }
            //pnlBremsen.Controls.Add(numSizeBremsen);

            //pnlGrunddaten.Controls.Remove(numSizeGrunddaten);
            foreach (CheckBox c in pnlGrunddaten.Controls)
            {
                c.CheckedChanged += new System.EventHandler(this.Control_CheckedChanged);
            }
            //pnlGrunddaten.Controls.Add(numSizeGrunddaten);

            //TODO: panel object is inside
            //pnlAFBLZB.Controls.Remove(numSizeAFBLZB);
            //foreach (CheckBox c in pnlAFBLZB.Controls)
            //{
            //    c.CheckedChanged += new System.EventHandler(this.Control_CheckedChanged);
            //}
            //pnlAFBLZB.Controls.Add(numSizeAFBLZB);

                      
            foreach (CheckBox c in pnlSchalterst.Controls)
            {
                c.CheckedChanged += new System.EventHandler(this.Control_CheckedChanged);
            }
            
            
        }

        

        #region HandleIncomingData
        private void TCPConnection_ErrorReceived(object sender, ZusiTcpException ex)
        {
            System.Windows.Forms.MessageBox.Show(String.Format("An error occured when receiving data: {0}", ex.Message));

            MyTCPConnection.Disconnnect();
            btnConnect.Text = "Connect";
        }

        private void  TCPConnection_FloatReceived(object sender, DataSet<float> data) // Handles MyTCPConnection.FloatReceived   
        {
            switch (data.Id)
            {
                #region Geschwindigkeit
                case 2561:
                {
                    geschwindigkeit = data.Value;
                    vmps = geschwindigkeit / 3.6;

                        

                    //displays speed either in kph or in mps
                    if(rbUnitkph.Checked)
                    {//TODO}
                    }
                    else if (rbUnitmps.Checked)
                    {//TODO
                    }

                    if (geschwindigkeit > 0.1) 
                        hasMoved = true;

                    //I think we don't need the autohide feature here
                    //if (hasMoved == true && alwaysShowSettings == false && cbHidesettings.Checked && debugging == false)
                    //{
                    //    if (settingsAreSeparated)
                    //        frmSettings.Hide();
                    //    else
                    //        pnlRight.Visible = false; //auto hide feature: If we start moving, right panel shall be hidden                        
                    //}

                    if (hasMoved == true && geschwindigkeit == 0) //if train has stopped
                    {
                        hasMoved = false;
                        alwaysShowSettings = false; //TEST: reset so that settings can autohide again
                    }

                    maxVerz = Convert.ToDouble(tbVerz.Text);
                    //TODO: check sharp braking by by determining deltaV
                    if (deltaV < -maxVerz) //if deceleration was greater than user set value maxVerz
                    {
                        scharf = true;
                    }

                    break;
                }
                #endregion

                #region Aktuelle Höchstgeschwindigkeit
                case 2660:
                {
                    geschwindigkeitMaxZul = data.Value;
                    break;
                }

                #endregion

                #region AFB Soll-Geschwindigkeit
                case 2578:
                {
                    afbsoll = data.Value;
                    //TODO
                    
                    break;
                }
                #endregion

                #region LZB Soll-Geschwindigkeit
                case 2636:
                {
                    lzbsoll = data.Value;
                    //TODO
                    break;
                }
                #endregion

                #region LZB Ziel-Geschwindigkeit
                case 2573:
                {
                    double lzbziel = data.Value;
                    //TODO
                    break;
                }
                #endregion
                                    
                #region LM LZB-Zielweg (ab 0)
                case 2635:
                {
                    //TODO: REMOVE
                    break;
                }
                #endregion

                #region Bremshundertstel
                case 2654: //Bremshundertstel
                {
                    if (data.Value > 0)  //TODO: do we still need this check?
                    {
                        setStatus("Verbunden");

                        brh = Convert.ToDouble(data.Value); //TODO: do we need to convert here? what if brh were a float?
                        //TODO
                    }
                    break;
                }
                #endregion

                #region Druck Hll
                case 2562:
                {
                    hlldruck = data.Value;
                    //TODO
                    break;
                }

                #endregion

                #region Druck Bz
                case 2563:
                {
                    float bzdruck = data.Value;
                    //TODO
                    break;
                }
                #endregion

                #region Druck HBL
                case 2564:
                    {
                        druckhbl = data.Value;
                        //TODO
                        break;
                    }
                #endregion

                #region Druck HLB
                case 2579:
                    {
                        druckhlb = data.Value;
                        //TODO
                        break;
                    }
                #endregion

                #region Streckenkilometer
                case 2645:
                {
                    streckenmeter = Convert.ToDouble(data.Value);   

                    //TODO: is this the best place, or does it belong into timerGraph_Tick?
                    graphStreckenKm = String.Format("{0:0.00}", (streckenmeter / 1000));
                    graphStreckenKmDouble = Convert.ToDouble(graphStreckenKm);

                    //TEST: Kilometersprung
                    deltaStreckenmeter = streckenmeterOld - streckenmeter;
                    
                    if (deltaStreckenmeter > 100)
                    {
                        //DEBUG
                        lblDebugKmsprung.Text = "KILOMETERSPRUNG bei : " + streckenmeter.ToString();
                        //TODO: Add some gridmark into chart at kmSprung
                        kmSprung = true;
                    }

                    streckenmeterOld = streckenmeter;
                    break;
                }
                #endregion

                #region Schalter Fahrstufen
                case 2611:
                {
                   double fahrschalter = data.Value - fahrschalterneutral;
                   //TODO
                   break;
                }
                #endregion

                #region Schalter Führerbremsventil // NOT YET NEEDED
                case 2612:
                {
                    //TODO: REMOVE
                    break;
                }
                #endregion

                #region Schalter AFB-Geschwindigkeit
                case 2615:
                {
                    //TODO: REMOVE

                    break;
                }
                #endregion

                #region Fahrstufe
                case 2576:
                {
                    //TODO
                    break;
                }
                #endregion

                default:
                    break;
            }
        }

        private void TCPConnection_BoolReceived(object sender, DataSet<bool> data) //Handles MyTCPConnection.BoolReceived
        {
            switch (data.Id)
            {               

                #region LM Sifa
                case 2596:
                    {
                        if (data.Value) // if true, LM Sifa is on 
                        {
                            //TODO
                        }
                        else
                        {
                            //TODO
                        }
                        break;
                    }
                #endregion

                #region LM Schleudern
                case 2599:
                    {
                        if (data.Value) // if true, LM Schleudern is on
                        {
                            //TODO
                        }
                        else
                        {
                            //TODO
                        }
                        break;
                    }
                #endregion

                #region Schalter AFB ein/aus
                case 2616:
                    {
                        if (data.Value) // if true, AFB switch is ON
                        {
                            afbistein = true;
                            //TODO
                        }
                        else // else, AFB switch is OFF
                        {
                            afbistein = false;
                           //TODO
                        }

                        break;
                    }
                #endregion

                #region Autopilot
                case 2647:
                    {
                        if (data.Value) //if true, autopilot is on...
                        {
                            autopilot = true;
                            //TODO
                           
                        }
                        else // if false, autopilot is off
                        {
                            autopilot = false;
                            //TODO                            
                        }
                        break;
                    }
                #endregion

                #region Reisezug
                case 2648:
                    {
                        if (data.Value) //if true -> passenger train
                        {
                            reisezug = true;                            
                        }
                        else //if false -> freight train
                        {
                            reisezug = false;                           
                        }
                        break;
                    }
                #endregion

                #region Schalter Sifa
                case 2621:
                    {
                        //TODO: REMOVE

                        break;
                    }
                #endregion

                default:
                    break;
            }
        }

        private void TCPConnection_DateTimeReceived(object sender, DataSet<DateTime> data) // Handles MyTCPConnection.DateTimeReceived 
        {
            switch (data.Id)
            {
                #region LM Uhrzeit (digital)
                case 2610:
                    {
                        //TODO
                        break;
                    }
                #endregion

                default:
                    break;
            }
            

        }

        private void TCPConnection_DoorsReceived(object sender, DataSet<DoorState> data) // Handles MyTCPConnection.DoorsReceived 
        {
            switch(data.Id)
            {
                case 2646:
                {
                    if (reisezug) // only display door status if passenger train
                    {
                        if (data.Value.ToString() == "Released")
                        {
                            //
                        }
                        if (data.Value.ToString() == "Open")
                        {
                           //
                        }
                        if (data.Value.ToString() == "ReadyToClose")
                        {
                            //
                        }
                        if (data.Value.ToString() == "Closing")
                        {
                            //
                        }
                        if (data.Value.ToString() == "Depart")
                        {
                            //
                        }
                        if (data.Value.ToString() == "Closed")
                        {
                            //
                        }
                        if (data.Value.ToString() == "Locked")
                        {
                            //
                        }
                    }
                    else // if freight train
                    {
                        //
                    }

                    break;
                }
            
                default:
                    break;
            }

        }

            //    //DEBUG TEST
        //    /* else if (dataSet.Id == MyTCPConnection["Zugdatei"])...
        //    {/*zugdateiOld = zugnummer;
        //        zugdatei = dataSet.Value.ToString();
        //        if (zugnummer != zugnummerOld)
            //            MessageBox.Show("DEBUG: Zugdatei has changed"); } */   

            
   
        
        #endregion

        #region SetStatus
        //here we are setting the program status depending on the connection state 
        public void setStatus(String statusNeu)
        {
            if (statusNeu == "Getrennt")
            {
                btnConnect.Text = "Verbinden";
                lblVerbstatus.Text = "Getrennt";
                //TEST
                btnAufzeichnung.Enabled = false;

                verbunden = false;
            }
            else if (statusNeu == "Warte")
            {

                //TODO: set an initial display for all pnlData numbers (like 888.88)
                btnConnect.Text = "Trennen";
                pnlRight.Visible = true;
                tabEinstellungen.SelectTab("tabAnzeigen1");
                lblVerbstatus.Text = "Warte auf Zusi";

            }
            else if (statusNeu == "Verbunden")
            {
                verbunden = true;
                lblVerbstatus.Text = "Verbunden mit Zusi";

                grpDebugoffline.Enabled = false; //DEBUG: disabling control of speed via numUD
                //TEST
                btnAufzeichnung.Enabled = true;
            }
        }
        #endregion

        public void DisplayTime()
        {
            //lblUhrzeit.Text = String.Format("{0:0}", stunde) + ":" + String.Format("{0:0}", minute) + ":"
            //    + String.Format("{0:0}", sekunde);

            //label8.Text = stunde.ToString();
            //label9.Text = minute.ToString();
            //label10.Text = sekunde.ToString();
        }

        #region Night- and Daymode

        public void setNightmode()
        {
            this.BackColor = formnightcolor; //the whole main form's background color
            if (settingsAreSeparated) // if there's a separate settings window
                frmSettings.BackColor = formnightcolor;

            statusStrip1.BackColor = formnightcolor; //same for the status strip

            

            //setting colors for the tab pages
            foreach (TabPage tab in tabEinstellungen.Controls)
            {
                tab.BackColor = panelnightcolor;
            }

            //setting colors for the textboxes
            tbPort.BackColor = textboxnightcolor;
            tbServer.BackColor = textboxnightcolor;
            tbVerz.BackColor = textboxnightcolor;

            //setting colors for PZB90-Panel
            //TEST: darkening background
            //Color c1 = pnlDataPZB90.BackColor;
            //Color c2 = Color.FromArgb(c1.A, (Convert.ToInt32(c1.R*0.8)), (Convert.ToInt32(c1.G*0.8)), (Convert.ToInt32(c1.B*0.8)));
            //pnlDataPZB90.BackColor = c2;
           
            //setting colors for PZB90-Panel
            
            //TEST make btnDebug invisible
            btnDebugpanel.BackColor = formnightcolor;
            btnDebugpanel.ForeColor = formnightcolor;
        }

       
        public void setDaymode()
        {
            BackColor = formdaycolor; //the whole main form's background color
            if (settingsAreSeparated) // if there's a separate settings window
                frmSettings.BackColor = formdaycolor;
            statusStrip1.BackColor = formdaycolor; //same for the status strip           

            //setting colors for the labels
           

            //setting colors for the tab pages
            foreach (TabPage tab in tabEinstellungen.Controls)
            {
                tab.BackColor = paneldaycolor;
            }

            //setting colors for the textboxes
            tbServer.BackColor = textboxdaycolor;
            tbPort.BackColor = textboxdaycolor;
            tbVerz.BackColor = textboxdaycolor;

            //setting colors for PZB90-Panel
            //TEST: lightening background
            //Color c1 = pnlDataPZB90.BackColor;
            //Color c2 = Color.FromArgb(c1.A, (Convert.ToInt32(c1.R * 1.2)), (Convert.ToInt32(c1.G * 1.2)), (Convert.ToInt32(c1.B * 1.2)));
            //pnlDataPZB90.BackColor = c2;
           
                      

            //TEST make btnDebug invisible
            btnDebugpanel.BackColor = formdaycolor;
            btnDebugpanel.ForeColor = formdaycolor;
        }

        //if the user clicks the "Nachtmodus / Tagmodus" button
        private void btnNacht_Click(object sender, EventArgs e)
        {
            if (nightmode == false) //if we're not yet in nightmode...
            {
                nightmode = true;
                setNightmode();
                btnNacht.Text = "Tagmodus";
            }
            else
            {
                nightmode = false;
                setDaymode();
                btnNacht.Text = "Nachtmodus";
            }

            FokusAnZusi(); //determine if focus must be handed over to Zusi according to user settings

        }
        #endregion

        #region User Settings Interaction

        //either one or the other checkbox is allowed to be checked, or none
        private void cbFokusImmerzurueck_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        

        private void cbAFBgeschw_CheckedChanged(object sender, EventArgs e)
        {
               
        }
        
        private void cbLZBvsoll_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbLZBvziel_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbLZBweg_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbAFBLZB_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbGeschwindigkeit_CheckedChanged(object sender, EventArgs e)
        {
            graph1.Series["geschw"].Enabled = cbGeschwindigkeit.Checked;
        }

        private void cbStreckenmeter_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbDruckhll_CheckedChanged(object sender, EventArgs e)
        {
            graph1.Series["hlldruck"].Enabled = cbDruckhll.Checked;
        }

        private void cbDruckbz_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbBrh_CheckedChanged(object sender, EventArgs e)
        {
          
        }        

        private void cbLmsifa_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbLmschleudern_CheckedChanged(object sender, EventArgs e)
        {
            
        }        

        private void cbGrunddaten_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbBremsen_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbLmtueren_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbFahrstufe_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void cbFahrstufenschalter_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbDarstKm_CheckedChanged(object sender, EventArgs e)
        {
            StreckenmeterDarstfaktor = 1000;            
        }

        private void rbDarstMeter_CheckedChanged(object sender, EventArgs e)
        {
            StreckenmeterDarstfaktor = 1;           
        }

        private void cbTopmost_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTopmost.Checked == true)
            {
                this.TopMost = true;
                frmSettings.TopMost = true;
            }
            else
            {
                this.TopMost = false;
                frmSettings.TopMost = false;
            }
        }

        public void ResizeSifa()
        {
            
        }

        private void numSifagroesse_ValueChanged(object sender, EventArgs e)
        {
            ResizeSifa();
        }

        private void cbFahrschneutral_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbSchalterst_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        #endregion
        
        #region User Tab Interaction

        private void tabEinstellungen_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabEinstellungen.SelectedTab == tabEinstellungen.TabPages["tabSystem"] 
                | tabEinstellungen.SelectedTab == tabEinstellungen.TabPages["tabDarstellung"]
                | tabEinstellungen.SelectedTab == tabEinstellungen.TabPages["tabAnzeigen1"])
            {
                tabEinstellungen.Width = 220;
               int offsetX = pnlSettings.Location.X + pnlSettings.Width + 10;
                pnlDebug.Location = new Point(offsetX, pnlDebug.Location.Y);
            }
            else if (tabEinstellungen.SelectedTab == tabEinstellungen.TabPages["tabGraph"] && graphIsSeparated == false)
            {
                tabEinstellungen.Width = 450;
                int offsetX = pnlSettings.Location.X + pnlSettings.Width + 10;
                pnlDebug.Location = new Point(offsetX, pnlDebug.Location.Y);
            }
        }

        #endregion

        #region User Button Interaction

        ////setting user colors for night- and daymode
        //private void btnFarbeNacht_Click(object sender, EventArgs e)
        //{
        //    colorDialog1.ShowDialog();
        //}
        //private void btnFarbeTag_Click(object sender, EventArgs e)
        //{
        //    colorDialog1.ShowDialog();
        //}

        //if the user clicks the "Einstellungen" button...
        private void btnSettings_Click(object sender, EventArgs e)
        {

            pnlRight.Visible = !pnlRight.Visible;
            if (pnlRight.Visible)
                btnSettings.Text = "Ausblenden";
            else
                btnSettings.Text = "Einblenden";

            //if (settingsAreSeparated == false) // if settings are NOT in a separate window
            //{
            //    //TEST
            //    if (hasMoved)
            //    {
            //        alwaysShowSettings = true; //when we're moving, we do NOT want to autohide at the moment
            //        pnlRight.Visible = !pnlRight.Visible;
            //    }
            //    else
            //    {
            //        alwaysShowSettings = false;
            //        pnlRight.Visible = !pnlRight.Visible;

            //    }
            //}
            //else if (settingsAreSeparated == true)
            //{
            //    //TEST
            //    if (hasMoved)
            //    {
            //        alwaysShowSettings = true; //when we're moving, we do NOT want to autohide at the moment
            //        //pnlRight.Visible = !pnlRight.Visible;
            //        frmSettings.Visible = !frmSettings.Visible;
            //    }
            //    else
            //    {
            //        alwaysShowSettings = false;
            //        //pnlRight.Visible = !pnlRight.Visible;
            //        frmSettings.Visible = !frmSettings.Visible;
            //    }
            //}

            FokusAnZusi();
        }

        //if the user clicks the "Verbinden / Trennen" button
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        //DEBUG: shows the flag below the Sifa label (for testing positioning)
        private void btnFlag_Click(object sender, EventArgs e)
        {
            
        }

        //DEBUG: if the debug button has been clicked...
        private void btnDebugpanel_Click(object sender, EventArgs e)
        {
            if (debugging == true)  //if we are yet in debugging mode, turn debugging mode off
            {
                pnlDebug.Visible = false;
                debugging = false;
                btnDebugpanel.BackColor = Color.FromName("Control");
            }
            else if (debugging == false) //else turn debugging mode on
            {
                pnlDebug.Visible = true;
                debugging = true;
                btnDebugpanel.BackColor = Color.Salmon;

                //we want to have the debug panel visible on the right side of our tabbed panel plus 10 pt
                int offsetX = pnlSettings.Location.X + pnlSettings.Width + 10;
                pnlDebug.Location = new Point(offsetX, pnlDebug.Location.Y);
            }
        }

        //DEBUG: to test focus handling
        private void btnDebugFokusZusi_Click(object sender, EventArgs e)
        {
            String window = "Zusi";
            //SetActiveWindow(FindWindow(null, window));
            //TODO: check if SetActiveWindow makes a difference
            SetForegroundWindow(FindWindow(null, window));

        }

        #endregion


        //adding a global function for all checkboxes, main reason is to determine if user has clicked
        //a checkbox, if so it's being checked if Zusi shall have the window focus back
        //TODO: find a better and more elegant way to detect user interaction with ALL controls on the form
        private void Control_CheckedChanged(object sender, EventArgs e)
        {
            FokusAnZusi();
        }

        public void ResetDebugLabels() //resetting all the labels on the Debug panel to their initial state
        {
            //         
        }

        public void ResetGlobals() //resetting some variables
        {            
            hasMoved = false;
            pnlRight.Visible = true;
            abbruch = false;
            scharf = false;
            vMaxErreicht = false;
            gebremst = false;
        }

        //TEST: global function, TODO: find a better way
       

        //if called (lblFlag is showing), after x seconds turn off the flag and stop the timer
        private void timerFlag_Tick(object sender, EventArgs e)
        {
         
        }

        public void ShowFlagtest()
        {

        }
        
        public void FokusAnZusi()
        {
            String window = "Zusi";
            //SetActiveWindow(FindWindow(null, window));
            SetForegroundWindow(FindWindow(null, window));
        }

       
        private void timer100_Tick(object sender, EventArgs e)
        {
           //
        }

        

        private void cbPZBLM_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void numFahrschneutral_ValueChanged(object sender, EventArgs e)
        {
            
        }

        //TODO: rename method
        //DEBUG
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Color geschwDefaultColor = (graph1.Series["geschw"].Color);

            if (verbunden == false)
            {
                geschwindigkeit = Convert.ToDouble(numDebugsetspeed.Value);
                vmps = geschwindigkeit / 3.6;   
             
                //TEST
                DataPoint dp = new DataPoint(1, geschwindigkeit);
                if (geschwindigkeit >= 10)
                    dp.Color = Color.Black;
                else
                    dp.Color = geschwDefaultColor;

                graph1.Series["geschw"].Points.Add(dp);
            }
        }

        //TEST
        private void timerRailrunner_Tick(object sender, EventArgs e)
        {
            
        }

        private void btnDebugRailrunner_Click(object sender, EventArgs e)
        {
           
        }

        private void cbRailrunner_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void SetRR()
        {
           
        }

        private void btnRailrunner_Click(object sender, EventArgs e)
        {
           
        }

       

        private void numSizeGrunddaten_ValueChanged(object sender, EventArgs e)
        {
    
        }

        private void numSizeBremsen_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void numSizeRailrunner_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numSizeAFBLZB_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numRRfest_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void rbRRfrei_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbAFBVorwahl_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        
        private void rbAFBvor5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

       
        private void rbAFBvor10_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbRRcountdown_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbRRcountup_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDebugPlaysound_Click(object sender, EventArgs e)
        {
            PlayRRSound();
        }

        private void rbRRfest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbDruckhbl_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbDruckhlb_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void cbLZBlm_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void CMainWindow_Click(object sender, EventArgs e)
        {
            FokusAnZusi();
        }

        private void tabAnzeigen1_Click(object sender, EventArgs e)
        {
            FokusAnZusi();
        }

        private void tabDarstellung_Click(object sender, EventArgs e)
        {
            FokusAnZusi();
        }

        private void tabSystem_Click(object sender, EventArgs e)
        {
            FokusAnZusi();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox aBox = new AboutBox();
            //temporarily disable topMost so that the about box will be on top
            this.TopMost = false;
            frmSettings.TopMost = false;

            aBox.ShowDialog();

            this.TopMost = cbTopmost.Checked;
            frmSettings.TopMost = cbTopmost.Checked;
        }

        private void numDebugsetspeed_KeyUp(object sender, KeyEventArgs e)
        {
            if (verbunden == false)
            {
                geschwindigkeit = Convert.ToDouble(numDebugsetspeed.Value);
                vmps = geschwindigkeit / 3.6;
                //vAlt = vNeu;
                //vNeu = geschwindigkeit;
                //deltaV = vNeu - vAlt;
                //TODO
            }
        }

        int clicks = 0;
        private void lblSifa_Click(object sender, EventArgs e)
        {
            //TODO
            //if (clicks > 2)
            //    clicks = 0;

            //if (clicks == 0)
            //{
            //    double faktor = 0.6;
            //    lblSifa.Width = Convert.ToInt32(labelsifadefaultwidth * faktor);
            //    lblSifa.Height = Convert.ToInt32(labelsifadefaultheight * faktor);
            //    lblFlag.Width = Convert.ToInt32(labelflagdefaultwidth * faktor);

            //    clicks++;
            //}
            //else if (clicks == 1)
            //{
            //    double faktor = 0.8;
            //    lblSifa.Width = Convert.ToInt32(labelsifadefaultwidth * faktor);
            //    lblSifa.Height = Convert.ToInt32(labelsifadefaultheight * faktor);
            //    lblFlag.Width = Convert.ToInt32(labelflagdefaultwidth * faktor);

            //    clicks++;
            //}
            //else if (clicks == 2)
            //{
            //    double faktor = 1.3;
            //    lblSifa.Width = Convert.ToInt32(labelsifadefaultwidth * faktor);
            //    lblSifa.Height = Convert.ToInt32(labelsifadefaultheight * faktor);
            //    lblFlag.Width = Convert.ToInt32(labelflagdefaultwidth * faktor);

            //    clicks++;
            //}
            //else if (clicks == 3)
            //{
            //    double faktor = 1;
            //    lblSifa.Width = Convert.ToInt32(labelsifadefaultwidth * faktor);
            //    lblSifa.Height = Convert.ToInt32(labelsifadefaultheight * faktor);
            //    lblFlag.Width = Convert.ToInt32(labelflagdefaultwidth * faktor);

            //    clicks++;
            //}

        }

        private void timerResetSifaschalter_Tick(object sender, EventArgs e)
        {
           
        }

        private void timerCheckSifaschalter_Tick(object sender, EventArgs e)
        {
            //if (schaltersifa == 2)
            //{
            //    SetRR();
            //    schaltersifa = 0; //TODO: check if this is the right place
            //}            
        }

        private void cbHidesettings_CheckedChanged(object sender, EventArgs e)
        {
            //TEST
            if (hasMoved && cbHidesettings.Checked)
                pnlRight.Visible = false;
        }

        public void createSettingsForm()
        {
            
        }

        public void ShowSeparateGraphWindow()
        {
            if (showseparatedgraph && graphIsSeparated == false)            
            {
                frmGraph.BackColor = this.BackColor; // makes sure day-/nightmode is set for the form too

                frmGraph.StartPosition = FormStartPosition.Manual;
                frmGraph.Location = new Point(this.Location.X + this.Width + 10, this.Location.Y);

                this.Controls.Remove(pnlGraph); // removing settings panel from main form
                frmGraph.Controls.Add(pnlGraph); //adding settings panel to graph form               

                graphIsSeparated = true;

                //this.pnlGraph.Location = new Point(0, 0);
                //this.pnlGraph.Dock = DockStyle.None; //TEST - otherwise, frmGraph does not size properly
                this.pnlGraph.Dock = DockStyle.Fill; //TEST - otherwise, frmGraph does not size properly

                //frmGraph.AutoSize = true;
                //frmGraph.PerformAutoScale();
                frmGraph.Show();
               
                //DEBUG:
                //cbSettingsSeparate.Checked = true;

            }
            else if (showseparatedgraph == false && graphIsSeparated == true)
            {
                //this.pnlGraph.Location = new Point(pnlLeft.Location.X + pnlLeft.Width + 10, pnlLeft.Location.Y);
                frmGraph.Controls.Remove(pnlGraph);
                this.tabGraph.Controls.Add(pnlGraph);

                this.pnlGraph.Dock = DockStyle.Fill; //TEST, see above if()
                //this.pnlGraph.Visible = true;

                graphIsSeparated = false;

                frmGraph.Hide();

                //DEBUG:
                //cbSettingsSeparate.Checked = false;
            }        
        }

        public void ShowSeparateSettingsWindow()
        {

            if (cbSettingsSeparate.Checked && settingsAreSeparated == false)
            //DEBUG:  //WORKAROUND - if checkbox is bound to settings, weird things happened
            {
                //MessageBox.Show("SEPARATED");


                frmSettings.BackColor = this.BackColor; // makes sure day-/nightmode is set for the form too

                frmSettings.StartPosition = FormStartPosition.Manual;
                frmSettings.Location = new Point(this.Location.X + 200, this.Location.Y);

                this.Controls.Remove(pnlRight); // removing settings panel from main form
                frmSettings.Controls.Add(pnlRight); //adding settings panel to settings form               
                
                settingsAreSeparated = true;

                this.pnlRight.Location = new Point(0, 0);
                frmSettings.AutoSize = true;
                frmSettings.PerformAutoScale();
                frmSettings.Show();
               
                //DEBUG:
                cbSettingsSeparate.Checked = true;
                
            }
            else if(cbSettingsSeparate.Checked == false && settingsAreSeparated == true) //DEBUG:
                    //WORKAROUND - if checkbox is bound to settings, weird things happened
            {
                //MessageBox.Show("NOT separated");

                this.pnlRight.Location = new Point(pnlLeft.Location.X + pnlLeft.Width + 10, pnlLeft.Location.Y);
                this.Controls.Add(pnlRight);
                //cbHidesettings.Checked = hideSettingsCheckedOLD; // restore value from before settings were separated                
                this.pnlRight.Visible = true;

                settingsAreSeparated = false;

                frmSettings.Hide();

                //DEBUG:
                cbSettingsSeparate.Checked = false;
            }        
        }

        private void cbSettingsSeparate_CheckedChanged(object sender, EventArgs e)
        {
            ShowSeparateSettingsWindow();
        }

        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbUnitmps_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbUnitkph_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void grpManageSettings_Enter(object sender, EventArgs e)
        {

        }

        private void CMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //saving default user settings on FormClosing
            Properties.Settings.Default.Save();
            
        }

        private void btnDefaultSettings_Click(object sender, EventArgs e)
        {
            //TEST
            //set default values for all bound controls
            if(MessageBox.Show("Einstellungen auf Standardwerte zurücksetzen?", "Zurücksetzen", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                Properties.Settings.Default.Reset();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " speichert die Einstellungen "
                + "automatisch beim Beenden. Mit einer späteren Version werden mehrere Einstellungen anlegbar sein.");
        }

        private void btnDebugGraphSeparated_Click(object sender, EventArgs e)
        {
            //TEST
            cbGraphSeparate.Checked = true;
            ShowSeparateGraphWindow();
        }

        private void timerGraph_Tick(object sender, EventArgs e)
        {
            if (hasMoved)
            {
                //if (cbGraphGeschwindigkeit.Checked)
                graph1.Series["geschw"].Points.AddXY(graphStreckenKmDouble, geschwindigkeit);
                //
                graph1.Series["geschwMaxZul"].Points.AddXY(graphStreckenKmDouble, geschwindigkeitMaxZul);
                //if (cbGraphDruckhll.Checked)
                graph1.Series["hlldruck"].Points.AddXY(graphStreckenKmDouble, hlldruck);
                
                //TEST TODO plot kmSprung at 0, if true at 1
                graph1.Series["kmSprung"].Points.AddXY(graphStreckenKmDouble, Convert.ToDouble(kmSprung));

                if (kmSprung)
                    kmSprung = false;
            }
        }

        private void btnAufzeichnung_Click(object sender, EventArgs e)
        {
            //TODO
            if (graphIsRunning == false && verbunden) // Start recording if connected
            {
                graphIsRunning = true;
                timerGraph.Start();
                tabEinstellungen.SelectTab("tabGraph");
                
                btnAufzeichnung.BackColor = Color.LightGreen;
                btnAufzeichnung.Text = "Läuft...";
            }
            else if (verbunden == false)
            {
                MessageBox.Show("Zusi ist noch nicht verbunden.");
            }
            else if (graphIsRunning)  // Stop recording regardless of connection status
            {
                graphIsRunning = false;
                timerGraph.Stop();

                btnAufzeichnung.BackColor = Color.FromName("Control");
                btnAufzeichnung.Text = "Aufzeichnung";
            }
        }

        private void cbGraphSeparate_CheckedChanged(object sender, EventArgs e)
        {
            showseparatedgraph = cbGraphSeparate.Checked;
            ShowSeparateGraphWindow();
        }

        private void tabEinstellungen_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabEinstellungen.SelectedTab == tabEinstellungen.TabPages["tabGraph"] && graphIsSeparated == true)
                //We do not want the user to be able to select the tab here
                e.Cancel = true;
        }

        private void graph1_Click(object sender, EventArgs e)
        {

        }

        private void btnDebugTickmark_Click(object sender, EventArgs e)
        {
            //plot a tickmark            
            //graph1.Series["hlldruck"].Points.AddY(3);
            //graph1.Series["geschw"].Points.InsertXY(graph1.ChartAreas.GetEnumerator(), 5);
        }

        private void btnSeparateGraph_Click(object sender, EventArgs e)
        {
            switch (showseparatedgraph && graphIsSeparated)
            {
                case true:
                    {
                        showseparatedgraph = false; // reintegrate graph
                        ShowSeparateGraphWindow();
                        tabEinstellungen.SelectTab("tabGraph");
                        //change button Text
                        btnSeparateGraph.Text = "Graph ->";
                        break;
                    }
                case false:
                    {
                        showseparatedgraph = true; // separate graph

                        //TEST: make sure GraphForm is not minimized
                        //frmGraph.WindowState = FormWindowState.Normal;

                        //select tab before calling method, this way frmGraph.Location is set properly
                        tabEinstellungen.SelectTab("tabAnzeigen1");
                        ShowSeparateGraphWindow();
                        
                        //change button Text
                        btnSeparateGraph.Text = "Graph <-";
                        break;
                    }
                default: break;
            }

            //if graph is separated, check cb and vice versa
            cbGraphSeparate.Checked = showseparatedgraph;

            

        }

        private void btnDebugHidegeschw_Click(object sender, EventArgs e)
        {
            
        }

        private void cbGeschwMaxZul_CheckedChanged(object sender, EventArgs e)
        {
            graph1.Series["geschwMaxZul"].Enabled = cbGeschwMaxZul.Checked;
        }

        private void cbKmSprung_CheckedChanged(object sender, EventArgs e)
        {
            graph1.Series["kmSprung"].Enabled = cbKmSprung.Checked;
        }

        private void btnDebugFrmShift_Click(object sender, EventArgs e)
        {
            frmGraph.Location = new Point(100, 100);
        }
          
    }
}
