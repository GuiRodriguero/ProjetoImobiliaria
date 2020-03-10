<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPrincipal
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CadastrarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VizualizarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarClienteToolStripMenuItem, Me.AlterarClienteToolStripMenuItem, Me.VizualizarClienteToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'CadastrarClienteToolStripMenuItem
        '
        Me.CadastrarClienteToolStripMenuItem.Name = "CadastrarClienteToolStripMenuItem"
        Me.CadastrarClienteToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.CadastrarClienteToolStripMenuItem.Text = "&Cadastrar Cliente"
        '
        'AlterarClienteToolStripMenuItem
        '
        Me.AlterarClienteToolStripMenuItem.Name = "AlterarClienteToolStripMenuItem"
        Me.AlterarClienteToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.AlterarClienteToolStripMenuItem.Text = "&Editar Cliente"
        '
        'VizualizarClienteToolStripMenuItem
        '
        Me.VizualizarClienteToolStripMenuItem.Name = "VizualizarClienteToolStripMenuItem"
        Me.VizualizarClienteToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.VizualizarClienteToolStripMenuItem.Text = "&Vizualizar Cliente"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "&Sair"
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.ProjetoImob.My.Resources.Resources.IMG_20190529_WA0004
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(632, 592)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "mdiPrincipal"
        Me.Text = "MENU"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastrarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VizualizarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
