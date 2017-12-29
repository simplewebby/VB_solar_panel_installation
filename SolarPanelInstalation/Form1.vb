'Tsagan Garyaeva
'Comp-185
'Lab 8 Solar Panel

Public Class Form1
    'global variables
    Dim strFirstName As String
    Dim strLastName As String
    Dim intPhone As Integer
    Dim intNumOfPanels As Integer
    Dim intDepositAmount As Integer
    Dim dblTotal As Double
    Dim dblBalanceDue As Double
    Dim intAddPanels As Integer
    Dim intOnePanel As Integer = 1000
    Const int_BASE_INSTALLATION As Integer = 2000
    Const int_ADITTIONAL_PANEL As Integer = 300
    Const dbl_EXPESS_INSTALLATION As Double = 0.05
    Private result As String
    'validation of inputs
    Function ValidateFields()

        Dim result As String = " "
        If txtFirstName.Text.Length = 0 Then result = result & "-First Name is empty" & vbNewLine
        If txtLastName.Text.Length = 0 Then result = result & "-Last Name is empty" & vbNewLine
        If txtPhone.Text.Length = 0 Then result = result & "- Phone field is empty" & vbNewLine
        If Not Integer.TryParse(txtNumOfPanels.Text, intNumOfPanels) Or intNumOfPanels < 1 OrElse intNumOfPanels >= 1000 Then result = result & "- Invalid input. The number of panels must be between 1 and 1000" & vbNewLine
        If Not Integer.TryParse(txtDepositAmount.Text, intDepositAmount) OrElse intDepositAmount < 0 Then result = result & "- Invalid input. Deposit must be a numeric value" & vbNewLine
        result = result & "Installation options verified"
        Return result
    End Function






    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox3.Hide()
        GroupBox2.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhone.Clear()
        txtNumOfPanels.Clear()
        txtDepositAmount.Clear()
        txtDepositAmount.Clear()
        txtAddPanel.Clear()
        txtBalanceDue.Clear()
        txtTotal.Clear()
        txtDeposit.Clear()
        lblError.Text = " "
        GroupBox3.Hide()
        GroupBox2.Hide()

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        GroupBox2.Show()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhone.Clear()
        txtNumOfPanels.Clear()
        txtDepositAmount.Clear()
        txtDepositAmount.Clear()
        txtAddPanel.Clear()
        txtBalanceDue.Clear()
        txtTotal.Clear()
        txtDeposit.Clear()
        lblError.Text = " "
        GroupBox3.Hide()
        GroupBox2.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub InformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click
        GroupBox2.Show
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCheckForErrors_Click(sender As Object, e As EventArgs) Handles btnCheckForErrors.Click
        If ChargesToolStripMenuItem.Checked = False And InformationToolStripMenuItem.Checked = False Then ChargesToolStripMenuItem.Checked = True
        lblError.Text = ValidateFields()
        lblError.ForeColor = Color.Green
        GroupBox3.Show()
        Try
            'calling to validate
            'Dim errorStr As String = ValidateFields()
            'Dim strmes As String = MessageBox.Show(errorStr)
            'pass input to a result group box
            txtBaseCharge.Text = int_BASE_INSTALLATION
            txtDeposit.Text = txtDepositAmount.Text
            'calculating total and balance due if it is less than 2
            If intNumOfPanels <= 2 Then txtTotal.Text = int_BASE_INSTALLATION
            txtTotal.Text = int_BASE_INSTALLATION
            txtBalanceDue.Text = int_BASE_INSTALLATION - intDepositAmount
            'if it is more than 2
            If intNumOfPanels > 2 Then txtAddPanel.Text = (((intNumOfPanels * intOnePanel) - int_BASE_INSTALLATION) * int_ADITTIONAL_PANEL) / intOnePanel
            txtTotal.Text = int_BASE_INSTALLATION + CInt(txtAddPanel.Text)
            txtBalanceDue.Text = CDbl(txtTotal.Text) - intDepositAmount


            'convert txt to dbl and 5% is checked add to total and balance due 
            dblTotal = CDbl(txtTotal.Text)
            dblBalanceDue = CDbl(txtBalanceDue.Text)
            If chBoxExpInst.Checked = True Then txtTotal.Text = dblTotal + (dblTotal * dbl_EXPESS_INSTALLATION)
            txtBalanceDue.Text = (dblTotal + (dblTotal * dbl_EXPESS_INSTALLATION)) - intDepositAmount
        Catch ex As Exception


        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        GroupBox2.Show()
        lblError.Text = ValidateFields()
        lblError.ForeColor = Color.Red
        If ChargesToolStripMenuItem.Checked = True And InformationToolStripMenuItem.Checked = True Then ChargesToolStripMenuItem.Checked = True
    End Sub

    Private Sub ChargesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChargesToolStripMenuItem.Click

    End Sub

    Private Sub InstallationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstallationToolStripMenuItem.Click

    End Sub
End Class
