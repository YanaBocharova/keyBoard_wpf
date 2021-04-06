using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace WpfHomeWork2.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : Window
    {
        int tempTimer = 0;
        Random rendChar = new Random();
        string baseString = "QWERTYUIOPASDFGHJKLZXCVBNM~!@#$%^&*()_+{}|:\"<>?1234567890[],./\\`-=;'qwertyuiopasdfghjklzxcvbnm";
        bool keysStatus = true;
        int lenthtbComp;
        DispatcherTimer timer = null;

        static int currPos = 0;
        int countFails = 0;
        public int CountFails{get;set;}
     
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Init();

           
        }

        private void Init()
        {
            tbUser.IsEnabled = false;
            tbUser.Text = " ";
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
        }
        void Speed()
        {
            SpeedChar.Content = Math.Round(((double)tbUser.Text.Length / tempTimer) * 60).ToString();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            tempTimer++;
            Speed();
        }

        private void AnimationButtonPress(KeyEventArgs e)
        {


            if (e.Key == Key.D0)
            {
                btn0.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.D1)
            {
                btn1.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.D2)
            {
                btn2.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.D3)
            {
                btn3.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.D4)
            {
                btn4.Background = ColorButtonAnimation();
            }

            if (e.Key == Key.D5)
            {
                btn5.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.D6)
            {
                btn6.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.D7)
            {
                btn7.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.D8)
            {
                btn8.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.D9)
            {
                btn9.Background = ColorButtonAnimation();
            }
            
            if (e.Key == Key.OemMinus)
            {
                btnMinus.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.OemPlus)
            {
                btnPlus.Background = ColorButtonAnimation();
            }
            if(e.Key==Key.Back)
            {
                btnBackspace.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.Q)
            {
                btnQ.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.W)
            {
                btnW.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.E)
            {
                btnE.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.R)
            {
                btnR.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.T)
            {
                btnT.Background = ColorButtonAnimation();
            }

            if (e.Key == Key.Y)
            {
                btnY.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.U)
            {
                btnU.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.I)
            {
                btnI.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.O)
            {
                btnO.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.P)
            {
                btnP.Background = ColorButtonAnimation();
            }

            if (e.Key == Key.A)
            {
                btnA.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.S)
            {
                btnS.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.D)
            {
                btnD.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.F)
            {
                btnF.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.G)
            {
                btnG.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.L)
            {
                btnL.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.H)
            {
                btnH.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.J)
            {
                btnJ.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.K)
            {
                btnK.Background = ColorButtonAnimation();
            }

            if (e.Key == Key.Z)
            {
                btnZ.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.X)
            {
                btnX.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.C)
            {
                btnC.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.V)
            {
                btnV.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.B)
            {
                btnB.Background = ColorButtonAnimation();
            }

            if (e.Key == Key.N)
            {
                btnN.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.M)
            {
                btnM.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.Space)
            {
                btnSpace.Background = ColorButtonAnimation();
            }


            if (e.Key == Key.OemMinus)
            {
                btnMinus.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.OemPlus)
            {
                btnPlus.Background = ColorButtonAnimation();
            }


            if (e.Key == Key.Oem2)
            {
                btnQuestion.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.OemComma)
            {
                btnComma.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.OemPeriod)
            {
                btnPoint2.Background = ColorButtonAnimation();
            }

            if (e.Key == Key.Oem4)
            {
                btnOpenBrackets.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.Oem6)
            {
                btnCloseBracket.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.Oem5)
            {
                btnLine.Background = ColorButtonAnimation();
            }

            if (e.Key == Key.Oem1)
            {
                btnColon.Background = ColorButtonAnimation();
            }
            if (e.Key == Key.Oem7)
            {
                btnPoint.Background = ColorButtonAnimation();
            }

        }
        private void ButtonAnimation_KeyUp(object sender, KeyEventArgs e)
        {

            AnimationButtonPress(e);
            CapsKeyUpSymbols(e);
            ShiftPressSymbols(e);
            if (tbUser.Text.Length < lenthtbComp) {
                if (e.Key == Key.Back)
                {
                    if (currPos > 0)
                    {
                        currPos--;
                    }
                    if (currPos <= 0)
                    {
                        currPos = 0;
                    }
                }

                if (tbUser.Text[currPos] != tbComp.Text[currPos] &&
                    e.Key != Key.Back )
                {
                    countFails++;
                    fails_label_count.Content = countFails;
                }
                if (e.Key != Key.CapsLock &&
                    e.Key != Key.LeftShift &&
                    e.Key != Key.Back &&
                    e.Key != Key.RightShift &&
                    e.Key != Key.LeftAlt &&
                    e.Key != Key.RightAlt &&
                    e.Key != Key.LeftCtrl &&
                    e.Key != Key.RightCtrl &&
                    e.Key != Key.Enter &&
                    e.Key != Key.System &&
                    e.Key != Key.Up &&
                    e.Key != Key.Down &&
                    e.Key != Key.Right &&
                    e.Key != Key.Left )
                {
                    currPos++;
                    
                }
            }
            if(tbUser.Text.Length >= lenthtbComp && countFails == 0)
            {
                StopAction();
                tbUser.Text = "You winner !!!";
            }
            if(tbUser.Text.Length == lenthtbComp && countFails > 0)
            {
                StopAction();
                tbUser.Text = "Try again ?";
            }

        }

        private void ShiftPressSymbols(KeyEventArgs e)
        {
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                keysStatus = (keysStatus == true) ? UpperSymbols() : LoverSymbols();
            }
        }

        private void CapsKeyUpSymbols(KeyEventArgs e)
        {

            if (e.Key == Key.CapsLock)
            {
                keysStatus = (keysStatus == true) ? UpperLetters() : LoverLetters();
            }
        }
        private void TBUserShiftPress_KeyDown(object sender, KeyEventArgs e)
        {
            ShiftPressSymbols(e);
        }
        private SolidColorBrush ColorButtonAnimation()
        {
            Color fromRGB = Color.FromRgb(102, 255, 255); ;
            Color ToRGB = Color.FromRgb(255, 0, 0);
            SolidColorBrush myBrush = new SolidColorBrush();
            myBrush.Color = Colors.Black;
            ColorAnimation myAnimation = new ColorAnimation();
            myAnimation.From = fromRGB;
            myAnimation.To = ToRGB;
            myAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(400));
            myAnimation.AutoReverse = true;
            myBrush.BeginAnimation(SolidColorBrush.ColorProperty, myAnimation);

            return myBrush;
        }

        private void StopAction()
        {
            btnStart.IsEnabled = true;
            currPos = 0;
            SliderDifficulty.IsEnabled = true;
            CaseLevel.IsEnabled = true;
            btnStop.IsEnabled = false;
            tbUser.Text = "";
            tbComp.Text = "";
            fails_label_count.Content = 0;
            SpeedChar.Content = 0;
            tbUser.IsReadOnly = true;
            tbUser.IsEnabled = false;
            timer.Stop();
            tempTimer = 0;
            countFails = 0;
        }
        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            StopAction();
        }

        // создание рандомной строки
        private void CollectString(int countChar, string baseString, bool casesentetive)
        {
            string str = "";
            int sensitive = (casesentetive) ? 10 : 0;
            for (int i = 0; i < countChar; i++)
            {
                str += baseString[rendChar.Next(sensitive, baseString.Length)];
            }
            str += " ";

            int countString = (casesentetive) ? 30 : 70;

            for (int i = 0; i < countString; i++)
            {
                tbComp.Text += str[rendChar.Next(0, str.Length)];
            }
        }
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
                tbUser.Text = " ";
                btnStart.IsEnabled = false;
                SliderDifficulty.IsEnabled = false;
                CaseLevel.IsEnabled = false;
                btnStop.IsEnabled = true;
                tempTimer = 0;
                timer.Start();
                CollectString(Convert.ToInt32(Difficulty.Content), baseString, !(bool)CaseLevel.IsChecked);
                lenthtbComp = tbComp.Text.Length;
                tbUser.IsReadOnly = false;
                tbUser.IsEnabled = true;
                tbUser.Focus();

        }

        private void SliderDifficulty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int num = 0;
            Slider s = sender as Slider;
            num = (int)s.Value;
            Difficulty.Content = num.ToString();
        }

        private void CaseSensitive_Checked(object sender, RoutedEventArgs e)
        {
            SliderDifficulty.Maximum = 100;
        }
        private void CaseSensitive_Unchecked(object sender, RoutedEventArgs e)
        {
            SliderDifficulty.Maximum = 50;
        }

        private bool UpperLetters()
        {

            btnQ.Content = "Q";
            btnW.Content = "W";
            btnE.Content = "E";
            btnR.Content = "R";
            btnT.Content = "T";
            btnY.Content = "Y";
            btnU.Content = "U";
            btnI.Content = "I";
            btnO.Content = "O";
            btnP.Content = "P";
            btnA.Content = "A";
            btnS.Content = "S";
            btnD.Content = "D";
            btnF.Content = "F";
            btnG.Content = "G";
            btnH.Content = "H";
            btnJ.Content = "J";
            btnK.Content = "K";
            btnL.Content = "L";
            btnZ.Content = "Z";
            btnX.Content = "X";
            btnC.Content = "C";
            btnV.Content = "V";
            btnB.Content = "B";
            btnN.Content = "N";
            btnM.Content = "M";

            return false;

        }
        private bool LoverLetters()
        {

            btnQ.Content = "q";
            btnW.Content = "w";
            btnE.Content = "e";
            btnR.Content = "r";
            btnT.Content = "t";
            btnY.Content = "y";
            btnU.Content = "u";
            btnI.Content = "i";
            btnO.Content = "o";
            btnP.Content = "p";
            btnA.Content = "a";
            btnS.Content = "s";
            btnD.Content = "d";
            btnF.Content = "f";
            btnG.Content = "g";
            btnH.Content = "h";
            btnJ.Content = "j";
            btnK.Content = "k";
            btnL.Content = "l";
            btnZ.Content = "z";
            btnX.Content = "x";
            btnC.Content = "c";
            btnV.Content = "v";
            btnB.Content = "b";
            btnN.Content = "n";
            btnM.Content = "m";

            return true;
        }
        private bool UpperSymbols()
        {
            btnOem3.Content = "~";
            btn1.Content = "!";
            btn2.Content = "@";
            btn3.Content = "#";
            btn4.Content = "$";
            btn5.Content = "%";
            btn6.Content = "^";
            btn7.Content = "&";
            btn8.Content = "*";
            btn9.Content = "(";
            btn0.Content = ")";
            btnMinus.Content = "_";
            btnPlus.Content = "+";
            btnOpenBrackets.Content = "{";
            btnCloseBracket.Content = "}";
            btnLine.Content = " \\";
            btnColon.Content = ":";
            btnPoint.Content = ".";
            btnComma.Content = "<";
            btnPoint2.Content = ">";
            btnQuestion.Content = "?";

            return false;
        }
        private bool LoverSymbols()
        {
            btnOem3.Content = "`";
            btn1.Content = "1";
            btn2.Content = "2";
            btn3.Content = "3";
            btn4.Content = "4";
            btn5.Content = "5";
            btn6.Content = "6";
            btn7.Content = "7";
            btn8.Content = "8";
            btn9.Content = "9";
            btn0.Content = "0";
            btnMinus.Content = "-";
            btnPlus.Content = "=";
            btnOpenBrackets.Content = "[";
            btnCloseBracket.Content = "]";
            btnLine.Content = "\\";
            btnColon.Content = ";";
            btnPoint.Content = "'";
            btnComma.Content = ",";
            btnPoint2.Content = ".";
            btnQuestion.Content = "/";

            return true;
        }

       
    }
}
