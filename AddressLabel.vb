Option Strict On
Option Explicit On
Public Class AddressLabel
    Sub SetDefaults()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        DisplayLabel.Text = ""

        FirstNameTextBox.Focus()
    End Sub
    Function ValidateUserFields() As Boolean
        'TODO
        '[x]First cannot be blank
        '[x]Last cannot be blank
        '[x]Street Address cannot be blank
        '[x]City cannot be blank
        '[x]State cannot be balnk
        '[x]Zip cannot be blank
        '[x]Zip must be a whole number
        Dim zip As ULong
        Dim message As String

        If FirstNameTextBox.Text = "" Then
            message &= "First name is required!" & vbNewLine
        End If

        If LastNameTextBox.Text = "" Then
            message &= "Last name is required!" & vbNewLine
        End If

        If StreetAddressTextBox.Text = "" Then
            message &= "Last name is required!" & vbNewLine
        End If

        If CityTextBox.Text = "" Then
            message &= "Last name is required!" & vbNewLine
        End If

        If StateTextBox.Text = "" Then
            message &= "Last name is required!" & vbNewLine
        End If
        Try
            zip = CULng(ZipTextBox.Text)
        Catch ex As Exception
            message &= "Zip is required and must be a whole number!" & vbNewLine
        End Try

        If message <> "" Then
            MsgBox(message, MsgBoxStyle.Critical, "User Error")
            Return False
        Else
            Return True

        End If
    End Function
    Sub DisplayData()
        DisplayLabel.Text = ""
        DisplayLabel.Text = $"{FirstNameTextBox.Text} &{LastNameTextBox.Text}  
{StreetAddressTextBox.Text}
{CityTextBox.Text}, {StateTextBox.Text} &{ZipTextBox.Text}"

    End Sub


    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        If ValidateUserFields() = True Then
            DisplayData()
        Else
            DisplayLabel.Text = ""
        End If

    End Sub

End Class
