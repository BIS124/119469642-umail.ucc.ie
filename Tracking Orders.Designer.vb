<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrack
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.rtbAwaitingShipping = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAwaitingShipping = New System.Windows.Forms.Label()
        Me.lblAwaitingCustomization = New System.Windows.Forms.Label()
        Me.rtbAwaitingCustomization = New System.Windows.Forms.RichTextBox()
        Me.rtbCustomized = New System.Windows.Forms.RichTextBox()
        Me.lblBeingCustomized = New System.Windows.Forms.Label()
        Me.lblCustomized = New System.Windows.Forms.Label()
        Me.rtbOutlet = New System.Windows.Forms.RichTextBox()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.txtOrderID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(73, 507)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(87, 36)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnReceipt
        '
        Me.btnReceipt.Location = New System.Drawing.Point(881, 507)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(261, 36)
        Me.btnReceipt.TabIndex = 1
        Me.btnReceipt.Text = "Proceed to Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = True
        '
        'rtbAwaitingShipping
        '
        Me.rtbAwaitingShipping.Location = New System.Drawing.Point(856, 111)
        Me.rtbAwaitingShipping.Name = "rtbAwaitingShipping"
        Me.rtbAwaitingShipping.Size = New System.Drawing.Size(214, 91)
        Me.rtbAwaitingShipping.TabIndex = 2
        Me.rtbAwaitingShipping.Text = "Your Style are really busy at the moment and will ship your order to their facili" &
    "ties as soon as possible."
        Me.rtbAwaitingShipping.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(406, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 3
        '
        'lblAwaitingShipping
        '
        Me.lblAwaitingShipping.AutoSize = True
        Me.lblAwaitingShipping.Location = New System.Drawing.Point(590, 114)
        Me.lblAwaitingShipping.Name = "lblAwaitingShipping"
        Me.lblAwaitingShipping.Size = New System.Drawing.Size(170, 20)
        Me.lblAwaitingShipping.TabIndex = 4
        Me.lblAwaitingShipping.Text = "Still Awaiting Shipment"
        Me.lblAwaitingShipping.Visible = False
        '
        'lblAwaitingCustomization
        '
        Me.lblAwaitingCustomization.AutoSize = True
        Me.lblAwaitingCustomization.Location = New System.Drawing.Point(590, 220)
        Me.lblAwaitingCustomization.Name = "lblAwaitingCustomization"
        Me.lblAwaitingCustomization.Size = New System.Drawing.Size(203, 20)
        Me.lblAwaitingCustomization.TabIndex = 5
        Me.lblAwaitingCustomization.Text = "Still Awaiting Customization"
        Me.lblAwaitingCustomization.Visible = False
        '
        'rtbAwaitingCustomization
        '
        Me.rtbAwaitingCustomization.Location = New System.Drawing.Point(856, 220)
        Me.rtbAwaitingCustomization.Name = "rtbAwaitingCustomization"
        Me.rtbAwaitingCustomization.Size = New System.Drawing.Size(214, 76)
        Me.rtbAwaitingCustomization.TabIndex = 6
        Me.rtbAwaitingCustomization.Text = "Your Style has shipped your order and its in the queue to be customised."
        '
        'rtbCustomized
        '
        Me.rtbCustomized.Location = New System.Drawing.Point(856, 302)
        Me.rtbCustomized.Name = "rtbCustomized"
        Me.rtbCustomized.Size = New System.Drawing.Size(214, 92)
        Me.rtbCustomized.TabIndex = 7
        Me.rtbCustomized.Text = "Right now, the Your Style team are working really hard on customizing the items y" &
    "ou requested."
        Me.rtbCustomized.Visible = False
        '
        'lblBeingCustomized
        '
        Me.lblBeingCustomized.AutoSize = True
        Me.lblBeingCustomized.Location = New System.Drawing.Point(590, 305)
        Me.lblBeingCustomized.Name = "lblBeingCustomized"
        Me.lblBeingCustomized.Size = New System.Drawing.Size(138, 20)
        Me.lblBeingCustomized.TabIndex = 8
        Me.lblBeingCustomized.Text = "Being Customized"
        '
        'lblCustomized
        '
        Me.lblCustomized.AutoSize = True
        Me.lblCustomized.Location = New System.Drawing.Point(590, 400)
        Me.lblCustomized.Name = "lblCustomized"
        Me.lblCustomized.Size = New System.Drawing.Size(134, 40)
        Me.lblCustomized.TabIndex = 9
        Me.lblCustomized.Text = "Customized and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "returned to Outlet"
        Me.lblCustomized.Visible = False
        '
        'rtbOutlet
        '
        Me.rtbOutlet.Location = New System.Drawing.Point(856, 400)
        Me.rtbOutlet.Name = "rtbOutlet"
        Me.rtbOutlet.Size = New System.Drawing.Size(214, 89)
        Me.rtbOutlet.TabIndex = 10
        Me.rtbOutlet.Text = "Your item(s) have customized,packaged & on the way to the Your Style outlet."
        Me.rtbOutlet.Visible = False
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(103, 113)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(70, 20)
        Me.lblOrderID.TabIndex = 11
        Me.lblOrderID.Text = "Order ID"
        '
        'txtOrderID
        '
        Me.txtOrderID.Location = New System.Drawing.Point(250, 107)
        Me.txtOrderID.Name = "txtOrderID"
        Me.txtOrderID.Size = New System.Drawing.Size(156, 26)
        Me.txtOrderID.TabIndex = 12
        '
        'frmTrack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 600)
        Me.Controls.Add(Me.txtOrderID)
        Me.Controls.Add(Me.lblOrderID)
        Me.Controls.Add(Me.rtbOutlet)
        Me.Controls.Add(Me.lblCustomized)
        Me.Controls.Add(Me.lblBeingCustomized)
        Me.Controls.Add(Me.rtbCustomized)
        Me.Controls.Add(Me.rtbAwaitingCustomization)
        Me.Controls.Add(Me.lblAwaitingCustomization)
        Me.Controls.Add(Me.lblAwaitingShipping)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtbAwaitingShipping)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmTrack"
        Me.Text = "Tracking Orders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents btnReceipt As Button
    Friend WithEvents rtbAwaitingShipping As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAwaitingShipping As Label
    Friend WithEvents lblAwaitingCustomization As Label
    Friend WithEvents rtbAwaitingCustomization As RichTextBox
    Friend WithEvents rtbCustomized As RichTextBox
    Friend WithEvents lblBeingCustomized As Label
    Friend WithEvents lblCustomized As Label
    Friend WithEvents rtbOutlet As RichTextBox
    Friend WithEvents lblOrderID As Label
    Friend WithEvents txtOrderID As TextBox
End Class
