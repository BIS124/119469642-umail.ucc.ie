Public Class frmTrack
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        frmReceipt.Show()
        Me.Close()
    End Sub

    Private Sub rchOutlet_TextChanged(sender As Object, e As EventArgs) Handles rtbOutlet.TextChanged

    End Sub

    Private Sub txtOrderID_TextChanged(sender As Object, e As EventArgs) Handles txtOrderID.TextChanged
        If txtOrderID.Text = "25849" Then
            rtbAwaitingShipping.Visible = True
            rtbAwaitingCustomization.Visible = False
            rtbCustomized.Visible = False
            rtbOutlet.Visible = False
        End If

        If txtOrderID.Text = "36724" Then
            rtbAwaitingShipping.Visible = False
            rtbAwaitingCustomization.Visible = False
            rtbCustomized.Visible = True
            rtbOutlet.Visible = False
        End If

        If txtOrderID.Text = "45269" Then
            rtbAwaitingShipping.Visible = False
            rtbAwaitingCustomization.Visible = False
            rtbCustomized.Visible = False
            rtbOutlet.Visible = True
        End If

        If txtOrderID.Text = "75247" Then
            rtbAwaitingShipping.Visible = False
            rtbAwaitingCustomization.Visible = True
            rtbCustomized.Visible = False
            rtbOutlet.Visible = False
        End If

        If txtOrderID.Text = "89694" Then
            rtbAwaitingShipping.Visible = True
            rtbAwaitingCustomization.Visible = False
            rtbCustomized.Visible = False
            rtbOutlet.Visible = False
        End If
    End Sub
