namespace Demchenko_BCSH1_SP.Control;

public partial class UserControlLabelledTBoxReadOnly : UserControl
{
    public string LabelText { get => labelName.Text; set => labelName.Text = value; }
    public string TextBoxText { get => tbName.Text; set => tbName.Text = value; }

    public UserControlLabelledTBoxReadOnly()
    {
        InitializeComponent();
    }
}
