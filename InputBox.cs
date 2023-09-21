using System;
using System.Windows.Forms;

public static class InputBox
{
    public static string Show(string prompt, string caption)
    {
        Form inputForm = new Form();
        Label label = new Label();
        TextBox textBox = new TextBox();
        Button okButton = new Button();

        inputForm.Text = caption;
        label.Text = prompt;

        okButton.Text = "OK";
        okButton.DialogResult = DialogResult.OK;

        label.SetBounds(12, 15, 372, 13);
        textBox.SetBounds(12, 45, 372, 20);
        okButton.SetBounds(309, 80, 75, 30);

        label.AutoSize = true;
        textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
        okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

        inputForm.ClientSize = new System.Drawing.Size(400, 125); // Aumentado o tamanho da janela

        inputForm.Controls.AddRange(new Control[] { label, textBox, okButton });
        inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
        inputForm.StartPosition = FormStartPosition.CenterScreen;
        inputForm.MinimizeBox = false;
        inputForm.MaximizeBox = false;
        inputForm.AcceptButton = okButton;

        DialogResult result = inputForm.ShowDialog();
        return result == DialogResult.OK ? textBox.Text : "";
    }
}