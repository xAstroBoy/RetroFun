using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using RetroFun.Controls;
using Sulakore.Communication;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class CustomMotto : ObservablePage
    {


        private bool _animatedMottoChecked;
        public bool animatedMottoChecked
        {
            get => _animatedMottoChecked;
            set
            {
                _animatedMottoChecked = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _ShowPreview;
        public bool ShowPreview
        {
            get => _ShowPreview;
            set
            {
                _ShowPreview = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _SpeedTimer;
        public int SpeedTimer
        {
            get => _SpeedTimer;
            set
            {
                _SpeedTimer = value;
                RaiseOnPropertyChanged();
            }
        }


        public CustomMotto()
        {
            InitializeComponent();
            PreviewMottoAnimations();
            Bind(EnableAnimatedChbx, "Checked", nameof(animatedMottoChecked));
            Bind(SpeedTime, "Value", nameof(SpeedTimer));

        }

        private void PreviewMottoAnimations()
        {

            if (!alreadystarted)
            {
                
                RotateAnimation();
                WaweAnimation();


                alreadystarted = true;
            }
        }

        #region Animations On motto

        private void RotateAnimationToMotto()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.Name = "MottoRotationAnim";
                Thread.CurrentThread.IsBackground = true;
                if (animatedMottoChecked)
                {
                    if (FirstMottoAnim.Checked)
                    {
                        SetMottoAnimation(animation_type_one_step_one, MottoToBox.Text, animation_type_one_step_one);
                                        Thread.Sleep(SpeedTimer);
                        SetMottoAnimation(animation_type_one_step_two, MottoToBox.Text, animation_type_one_step_two);
                                        Thread.Sleep(SpeedTimer);
                        SetMottoAnimation(animation_type_one_step_three, MottoToBox.Text, animation_type_one_step_three);
                                        Thread.Sleep(SpeedTimer);
                        SetMottoAnimation(animation_type_one_step_four, MottoToBox.Text, animation_type_one_step_four);
                                        Thread.Sleep(SpeedTimer);
                        RotateAnimationToMotto();
                    }
                    else
                    {
                        if (SecondMottoAnim.Checked)
                        {
                            WaweAnimationToMotto();
                        }
                        Thread.CurrentThread.Abort();
                    }
                }
                else
                {
                    Thread.CurrentThread.Abort();

                }
            }).Start();
        }


        private void WaweAnimationToMotto()
        {

            new Thread(() =>
            {
                Thread.CurrentThread.Name = "WawerotationAnim";
                Thread.CurrentThread.IsBackground = true;
                if (animatedMottoChecked)
                {
                    if (SecondMottoAnim.Checked)
                    {
                        SetMottoAnimation(animation_type_two_step_one, MottoToBox.Text, animation_type_two_step_one);
                                        Thread.Sleep(SpeedTimer);
                        SetMottoAnimation(animation_type_two_step_two, MottoToBox.Text, animation_type_two_step_two);
                                        Thread.Sleep(SpeedTimer);
                        SetMottoAnimation(animation_type_two_step_three, MottoToBox.Text, animation_type_two_step_three);
                                        Thread.Sleep(SpeedTimer);
                        SetMottoAnimation(animation_type_two_step_four, MottoToBox.Text, animation_type_two_step_four);
                                        Thread.Sleep(SpeedTimer);
                        SetMottoAnimation(animation_type_two_step_five, MottoToBox.Text, animation_type_two_step_five);
                                        Thread.Sleep(SpeedTimer);
                        WaweAnimationToMotto();
                    }
                    else
                    {
                        if(FirstMottoAnim.Checked)
                        {
                            RotateAnimation();
                        }
                        Thread.CurrentThread.Abort();

                    }
                }
                else
                {
                    Thread.CurrentThread.Abort();

                }

            }).Start();
        }

        #endregion


        #region Animation Previews

        private void WaweAnimation()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.Name = "WawerotationAnimPrew";
                Thread.CurrentThread.IsBackground = true;
                RadioButtonTextChange(SecondMottoAnim, animation_type_two_step_one);
                                Thread.Sleep(SpeedTimer);
                RadioButtonTextChange(SecondMottoAnim, animation_type_two_step_two);
                                Thread.Sleep(SpeedTimer);
                RadioButtonTextChange(SecondMottoAnim, animation_type_two_step_three);
                                Thread.Sleep(SpeedTimer);
                RadioButtonTextChange(SecondMottoAnim, animation_type_two_step_four);
                                Thread.Sleep(SpeedTimer);
                RadioButtonTextChange(SecondMottoAnim, animation_type_two_step_five);
                                Thread.Sleep(SpeedTimer);
                WaweAnimation();
            }).Start();

        }


        private void RotateAnimation()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.Name = "RotateAnimPrew";
                Thread.CurrentThread.IsBackground = true;
                RadioButtonTextChange(FirstMottoAnim, animation_type_one_step_one);
                Thread.Sleep(SpeedTimer);
                                Thread.Sleep(SpeedTimer);
                RadioButtonTextChange(FirstMottoAnim, animation_type_one_step_two);
                                Thread.Sleep(SpeedTimer);
                RadioButtonTextChange(FirstMottoAnim, animation_type_one_step_three);
                                Thread.Sleep(SpeedTimer);
                RadioButtonTextChange(FirstMottoAnim, animation_type_one_step_four);
                                Thread.Sleep(SpeedTimer);
                RotateAnimation();

            }).Start();

        }
    

        #endregion


        private void RadioButtonTextChange(RadioButton button, string text)
        {
            if (!IsHandleCreated)
                return;
               Invoke((MethodInvoker)delegate
                {
                    button.Text = text;
                });
        }


        private void FirstMottoAnim_CheckedChanged(object sender, EventArgs e)
        {
            RotateAnimationToMotto();

        }

        private void SecondMottoAnim_CheckedChanged(object sender, EventArgs e)
        {
            WaweAnimationToMotto();

        }

        private void AnimMottoCheck_CheckedChanged(object sender, EventArgs e)
        {
            RotateAnimationToMotto();
            WaweAnimationToMotto();
        }

        private void SetMottobtn_Click_1(object sender, EventArgs e)
        {
            SetMottoNoAnimation(MottoToBox.Text);
        }

        private void SetMottoNoAnimation(string text)
        {
            Connection.SendToServerAsync(Out.SaveMotto, text);
        }

        private void SetMottoAnimation(string border, string text, string bordertwo)
        {
            Connection.SendToServerAsync(Out.SaveMotto, border + " " + text + " " + bordertwo);
        }


        //private void SStartLoop_Click(object sender, EventArgs e)
        //{
        //    RotateAnimationToMotto();

        //    PreviewMottoAnimations();
        //}



//        private readonly animations[] _animations = new[]
//{
//            new animations("I", 1),
//            new animations("/", 2),
//            new animations("--", 3),
//            new animations("\\", 4),


//            new animations(":HEIDI:: (i.p.s)", 5),
//            new animations("Servedio (i.p.s)", 6)
//        };

//        private class animations
//        {
//            public int Number { get; }
//            public string Text { get; }

//            public animations(string text, int number)
//            {
//                Number = number;
//                Text = text;
//            }
//        }


        string animation_type_one_step_one = "I";
          string animation_type_one_step_two = "⁄";
          string animation_type_one_step_three = "--";
          string animation_type_one_step_four = "\\";

        string animation_type_two_step_one = "~~~~";
        string animation_type_two_step_two = "-~~~";
        string animation_type_two_step_three = "~-~~";
        string animation_type_two_step_four = "~~-~";
        string animation_type_two_step_five = "~~~-";

        bool alreadystarted = false;


    }
    }
