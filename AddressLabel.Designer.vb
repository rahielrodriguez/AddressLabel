<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLabel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddressLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ContentToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.ZipTextBox)
        Me.InputGroupBox.Controls.Add(Me.ZipLabel)
        Me.InputGroupBox.Controls.Add(Me.StateTextBox)
        Me.InputGroupBox.Controls.Add(Me.StateLabel)
        Me.InputGroupBox.Controls.Add(Me.CityTextBox)
        Me.InputGroupBox.Controls.Add(Me.CityLabel)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressTextBox)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressLabel)
        Me.InputGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.LastNameLabel)
        Me.InputGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.InputGroupBox.Location = New System.Drawing.Point(7, 16)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(404, 325)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Mailing Address"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(16, 285)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(93, 22)
        Me.ZipTextBox.TabIndex = 6
        Me.ContentToolTip.SetToolTip(Me.ZipTextBox, "This text box is made to enter the user's zip code")
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(13, 266)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(62, 16)
        Me.ZipLabel.TabIndex = 0
        Me.ZipLabel.Text = "Zip Code"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(16, 235)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(93, 22)
        Me.StateTextBox.TabIndex = 5
        Me.ContentToolTip.SetToolTip(Me.StateTextBox, "This text box is made to enter the user's state of residence")
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(13, 216)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(38, 16)
        Me.StateLabel.TabIndex = 0
        Me.StateLabel.Text = "State"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(16, 187)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(376, 22)
        Me.CityTextBox.TabIndex = 4
        Me.ContentToolTip.SetToolTip(Me.CityTextBox, "This text box is made to enter the user's city of residence")
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(13, 168)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(29, 16)
        Me.CityLabel.TabIndex = 0
        Me.CityLabel.Text = "City"
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(16, 140)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(376, 22)
        Me.StreetAddressTextBox.TabIndex = 3
        Me.ContentToolTip.SetToolTip(Me.StreetAddressTextBox, "This text box is made to enter the user's street address")
        '
        'StreetAddressLabel
        '
        Me.StreetAddressLabel.AutoSize = True
        Me.StreetAddressLabel.Location = New System.Drawing.Point(13, 121)
        Me.StreetAddressLabel.Name = "StreetAddressLabel"
        Me.StreetAddressLabel.Size = New System.Drawing.Size(96, 16)
        Me.StreetAddressLabel.TabIndex = 0
        Me.StreetAddressLabel.Text = "Street Address"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(16, 93)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(376, 22)
        Me.LastNameTextBox.TabIndex = 2
        Me.ContentToolTip.SetToolTip(Me.LastNameTextBox, "This text box is made to enter the user's last name")
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(13, 70)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(72, 16)
        Me.LastNameLabel.TabIndex = 0
        Me.LastNameLabel.Text = "Last Name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(16, 46)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(376, 22)
        Me.FirstNameTextBox.TabIndex = 1
        Me.ContentToolTip.SetToolTip(Me.FirstNameTextBox, "This text box is made to enter the user's first name")
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(13, 27)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(72, 16)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First Name"
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(429, 258)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(117, 82)
        Me.DisplayButton.TabIndex = 7
        Me.DisplayButton.Text = "Display Label"
        Me.ContentToolTip.SetToolTip(Me.DisplayButton, "This button is made to display the address content provided by the user in a cert" &
        "ain format in the Display Label")
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(562, 257)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(116, 82)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ContentToolTip.SetToolTip(Me.ClearButton, "This button is made to clear the address content provided by the user")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(700, 257)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(116, 82)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        Me.ContentToolTip.SetToolTip(Me.ExitButton, "This button is made to exit and close the program")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.DisplayLabel)
        Me.OutputGroupBox.Location = New System.Drawing.Point(424, 25)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(392, 226)
        Me.OutputGroupBox.TabIndex = 2
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Address Label"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(28, 29)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(0, 33)
        Me.DisplayLabel.TabIndex = 0
        Me.ContentToolTip.SetToolTip(Me.DisplayLabel, "This label is made to display the address content provided by the user in a certa" &
        "in format")
        '
        'ContentToolTip
        '
        Me.ContentToolTip.ToolTipTitle = "ContentToolTip"
        '
        'AddressLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 356)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Name = "AddressLabel"
        Me.Text = "Address Label Viewer"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents StreetAddressLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ContentToolTip As ToolTip
End Class
