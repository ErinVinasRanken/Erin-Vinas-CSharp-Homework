using System;
using System.Windows.Forms;

namespace Homework14_16_02
{
    public partial class frmPhotoShop : Form
    {
        //  Global constants
        const decimal EIGHTXTEN = 3.99M;     //   8" x 10" cost
        const decimal TENXTWELVE = 5.99M;     //  10" x 12" cost
        const decimal OTHERSIZES = 9.99M;     //  Size other than 8 x 10 or 10 x 12 cost
        const decimal UNFRAMED = 0.00M;     //  Unframed cost
        const decimal MATTED = 10.00M;     //  Matted cost
        const decimal FRAMED = 25.00M;     //  Framed cost

        //  Global variables
        double width = 0.00;      //  width  inputted
        double height = 0.00;      //  height inputted
        decimal totalCost = 0.00M;     //  total cost for picture
        RadioButton radioButtonFrame;
        RadioButton radioButtonColor;
        RadioButton radioButtonMaterial;
        RadioButton radioButtonStyle;
        string frameStr = "";         //  Unframed, Matted, or Framed
        string colorStr = "";         //  Black, Red, Green, Blue,  or White
        string materialStr = "";         //  Pine, Oak, Steel, Sivler, or Gold
        string styleStr = "";         //  Simple, Modern, Antique, Vintage, or Eclectic

        public frmPhotoShop()
        {
            InitializeComponent();
            //  https://social.msdn.microsoft.com/Forums/windows/en-US/c0c36595-9d98-40f7-8e6a-176a5a3af929/how-to-detect-which-radio-button-is-checked-inside-a-groupbox-control?forum=winforms
            //  Set up framed groupBox radioButtons
            radioButtonUnframed.CheckedChanged += new EventHandler(framed_Check_Changed);
            radioButtonMatted.CheckedChanged += new EventHandler(framed_Check_Changed);
            radioButtonFramed.CheckedChanged += new EventHandler(framed_Check_Changed);

            //  Set up color groupBox radioButtons
            radioButtonBlack.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonRed.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonGreen.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonBlue.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonWhite.CheckedChanged += new EventHandler(color_Check_Changed);

            //  Set up material groupBox radioButtons
            radioButtonPine.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonOak.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonSteel.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonSilver.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonGold.CheckedChanged += new EventHandler(material_Check_Changed);

            //  Set up style groupBox radioButtons
            radioButtonSimple.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonModern.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonAntique.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonVintage.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonEclectic.CheckedChanged += new EventHandler(style_Check_Changed);
        }

        //  This should fire when one of the framed groupBox radio buttons is clicked
        private void framed_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonFrame = (RadioButton)sender;

                frameStr = radioButtonFrame.Name.Substring(11);

                //MessageBox.Show("The Current switch Value is: " + frameStr);

                switch (frameStr)
                {
                    case "Unframed":
                        groupBoxColor.Enabled = false;
                        groupBoxMaterial.Enabled = false;
                        groupBoxStyle.Enabled = false;
                        break;

                    case "Matted":
                        groupBoxColor.Enabled = true;
                        radioButtonBlack.Checked = true;
                        groupBoxMaterial.Enabled = false;
                        groupBoxStyle.Enabled = false;
                        break;

                    case "Framed":
                        groupBoxColor.Enabled = false;
                        groupBoxMaterial.Enabled = true;
                        radioButtonPine.Checked = true;
                        groupBoxStyle.Enabled = true;
                        radioButtonSimple.Checked = true;
                        break;

                    default:
                        groupBoxColor.Enabled = false;
                        groupBoxMaterial.Enabled = false;
                        groupBoxStyle.Enabled = false;
                        break;
                }
            }
        }

        //  This should fire when one of the color groupBox radio buttons is clicked
        private void color_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {

                radioButtonColor = (RadioButton)sender;

                colorStr = radioButtonColor.Name.Substring(11);
            }
        }

        //  This should fire when one of the material groupBox radio buttons is clicked
        private void material_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {

                radioButtonMaterial = (RadioButton)sender;

                materialStr = radioButtonMaterial.Name.Substring(11);
            }
        }

        //  This should fire when one of the style groupBox radio buttons is clicked
        private void style_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonStyle = (RadioButton)sender;

                styleStr = radioButtonStyle.Name.Substring(11);
            }
        }

        //  This method is called when the calculate button is clicked
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = validateWidth();

            if (keepGoing)
            {
                keepGoing = validateHeight();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                calculateCost();
            }
            else
            {
                return;
            }
        }

        //  This method validates the inputted width
        private bool validateWidth()
        {
            try
            {
                width = Convert.ToDouble(textBoxWidth.Text);
                return true;
            }
            catch (FormatException fe)
            {
                writeMessage("Width Inputted Was Not Numeric.\nPlease Try Again." +
                                fe.Message,
                                "ILLEGAL WIDTH INPUTTED");
                textBoxWidth.Text = "";
                textBoxWidth.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException oore)
            {
                writeMessage("Width Inputted Was <= 0.\nPlease Try Again." +
                                oore.Message,
                                "NON-POSITIVE WIDTH INPUTTED");
                textBoxWidth.Text = "";
                textBoxWidth.Focus();
                return false;
            }
        }

        //  This method validates the inputted height
        private bool validateHeight()
        {
            try
            {
                height = Convert.ToDouble(textBoxHeight.Text);

                if (height <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }
            catch (FormatException fe)
            {
                writeMessage("Height Inputted Was Not Numeric.\nPlease Try Again." +
                             fe.Message,
                             "ILLEGAL HEIGHT INPUTTED");
                textBoxHeight.Text = "";
                textBoxHeight.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException oore)
            {
                writeMessage("Height Inputted Was <= 0.\nPlease Try Again." +
                             oore.Message,
                             "NON-POSITIVE HEIGHT INPUTTED");
                textBoxHeight.Text = "";
                textBoxHeight.Focus();
                return false;
            }
        }

        //  This method calculates the total cost
        private void calculateCost()
        {
            decimal areaCost = calculateAreaCost();
            decimal frameCost = calculateFrameCost();
            totalCost = areaCost + frameCost;

            labelTheCost.Text = totalCost.ToString("c");
        }

        private decimal calculateAreaCost()
        {
            double area = width * height;
            decimal ac = 0.00M;

            switch (area)
            {
                case 80.0:
                    ac = EIGHTXTEN;
                    break;

                case 120.0:
                    ac = TENXTWELVE;
                    break;

                default:
                    ac = OTHERSIZES;
                    break;
            }

            return ac;
        }

        private decimal calculateFrameCost()
        {
            decimal fc = 0.0M;

            //MessageBox.Show("The value of Frame is: " + radioButtonFrame.Name.Substring(11));

            //  Part of below was "gleaned" from the following URL (more in class):
            //  https://stackoverflow.com/questions/16100/convert-a-string-to-an-enum-in-c-sharp

            switch (radioButtonFrame.Name.Substring(11))
            {
                case "Unframed":
                    fc = UNFRAMED;
                    Photo p = new Photo(width, height);
                    labelTotals.Text = p.ToString();
                    break;

                case "Matted":
                    fc = MATTED;
                    MattedPhoto.Color colorEnum = (MattedPhoto.Color)Enum.Parse(typeof(MattedPhoto.Color), radioButtonColor.Text.ToUpper());
                    MattedPhoto mp = new MattedPhoto(width, height, colorEnum);
                    labelTotals.Text = mp.ToString();
                    break;

                case "Framed":
                    fc = FRAMED;
                    FramedPhoto.Material materialEnum = (FramedPhoto.Material)Enum.Parse(typeof(FramedPhoto.Material), radioButtonMaterial.Text.ToUpper());
                    FramedPhoto.Style styleEnum = (FramedPhoto.Style)Enum.Parse(typeof(FramedPhoto.Style), radioButtonStyle.Text.ToUpper());
                    FramedPhoto fp = new FramedPhoto(width, height, materialEnum, styleEnum);
                    labelTotals.Text = fp.ToString();
                    break;

                default:
                    break;
            }

            return fc;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            width = 0.0;
            height = 0.0;
            textBoxWidth.Text = "";
            textBoxHeight.Text = "";
            radioButtonUnframed.Checked = true;
            radioButtonBlack.Checked = true;
            radioButtonPine.Checked = true;
            radioButtonSimple.Checked = true;
            labelTheCost.Text = "";
            labelTotals.Text = "";
            textBoxWidth.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void writeMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
