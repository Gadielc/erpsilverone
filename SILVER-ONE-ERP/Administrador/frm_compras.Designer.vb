<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_compras
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BTN_SAVE = New DevExpress.XtraBars.BarButtonItem()
        Me.BTN_DELETE_ROW_SELEC = New DevExpress.XtraBars.BarButtonItem()
        Me.BTN_DELETE = New DevExpress.XtraBars.BarButtonItem()
        Me.LBL_RESULT_PROVIDER = New DevExpress.XtraBars.BarStaticItem()
        Me.LBL_RESULT_WAREH = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.CB_ALMACEN = New System.Windows.Forms.ComboBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.DT_FECHA = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CB_PROVIDER = New System.Windows.Forms.ComboBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_T_COMPRA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TXT_ID = New DevExpress.XtraEditors.TextEdit()
        Me.dgv_data = New System.Windows.Forms.DataGridView()
        Me.col_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_accesorio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_costo_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_precio_pub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_FECHA.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_FECHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_T_COMPRA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BTN_SAVE, Me.BTN_DELETE_ROW_SELEC, Me.BTN_DELETE, Me.LBL_RESULT_PROVIDER, Me.LBL_RESULT_WAREH})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 8
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl.Size = New System.Drawing.Size(1143, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Caption = "GUARDAR REGISTRO"
        Me.BTN_SAVE.Id = 1
        Me.BTN_SAVE.ImageOptions.LargeImage = Global.SILVER_ONE_ERP.My.Resources.Resources.save_32x321
        Me.BTN_SAVE.Name = "BTN_SAVE"
        '
        'BTN_DELETE_ROW_SELEC
        '
        Me.BTN_DELETE_ROW_SELEC.Caption = "ELIMINAR PARTIDA SELECCIONADA"
        Me.BTN_DELETE_ROW_SELEC.Id = 2
        Me.BTN_DELETE_ROW_SELEC.ImageOptions.Image = Global.SILVER_ONE_ERP.My.Resources.Resources.none_16x16
        Me.BTN_DELETE_ROW_SELEC.ImageOptions.LargeImage = Global.SILVER_ONE_ERP.My.Resources.Resources.none_32x32
        Me.BTN_DELETE_ROW_SELEC.Name = "BTN_DELETE_ROW_SELEC"
        '
        'BTN_DELETE
        '
        Me.BTN_DELETE.Caption = "ELIMINAR TODAS LAS PARTIDAS"
        Me.BTN_DELETE.Id = 3
        Me.BTN_DELETE.ImageOptions.Image = Global.SILVER_ONE_ERP.My.Resources.Resources.deletetable_16x16
        Me.BTN_DELETE.ImageOptions.LargeImage = Global.SILVER_ONE_ERP.My.Resources.Resources.deletetable_32x32
        Me.BTN_DELETE.Name = "BTN_DELETE"
        '
        'LBL_RESULT_PROVIDER
        '
        Me.LBL_RESULT_PROVIDER.Caption = "..."
        Me.LBL_RESULT_PROVIDER.Id = 6
        Me.LBL_RESULT_PROVIDER.ImageOptions.Image = Global.SILVER_ONE_ERP.My.Resources.Resources.female_32x32
        Me.LBL_RESULT_PROVIDER.Name = "LBL_RESULT_PROVIDER"
        '
        'LBL_RESULT_WAREH
        '
        Me.LBL_RESULT_WAREH.Caption = "..."
        Me.LBL_RESULT_WAREH.Id = 7
        Me.LBL_RESULT_WAREH.ImageOptions.Image = Global.SILVER_ONE_ERP.My.Resources.Resources.boorderitem_32x32
        Me.LBL_RESULT_WAREH.Name = "LBL_RESULT_WAREH"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "OPCIONES BASICAS"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BTN_SAVE)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BTN_DELETE_ROW_SELEC)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BTN_DELETE)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "OPCIONES"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.LBL_RESULT_PROVIDER)
        Me.RibbonStatusBar.ItemLinks.Add(Me.LBL_RESULT_WAREH)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 792)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1143, 31)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DockPanel1.ID = New System.Guid("1182ec78-5e30-41cb-ab24-222db2d58842")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 143)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.Options.ShowCloseButton = False
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(346, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(346, 649)
        Me.DockPanel1.Text = "DATOS DE LA COMPRA"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.TextEdit5)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl9)
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl2)
        Me.DockPanel1_Container.Controls.Add(Me.SeparatorControl1)
        Me.DockPanel1_Container.Controls.Add(Me.GroupControl1)
        Me.DockPanel1_Container.Controls.Add(Me.CB_ALMACEN)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl4)
        Me.DockPanel1_Container.Controls.Add(Me.DT_FECHA)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl3)
        Me.DockPanel1_Container.Controls.Add(Me.CB_PROVIDER)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl2)
        Me.DockPanel1_Container.Controls.Add(Me.TXT_T_COMPRA)
        Me.DockPanel1_Container.Controls.Add(Me.LabelControl1)
        Me.DockPanel1_Container.Controls.Add(Me.TXT_ID)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(337, 622)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.TextEdit3)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.TextEdit4)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 387)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(301, 88)
        Me.GroupControl2.TabIndex = 11
        Me.GroupControl2.Text = "PIEZAS TOTALES"
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(101, 54)
        Me.TextEdit3.MenuManager = Me.RibbonControl
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(149, 20)
        Me.TextEdit3.TabIndex = 9
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(6, 61)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl7.TabIndex = 8
        Me.LabelControl7.Text = "PARTIDAS:"
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(101, 28)
        Me.TextEdit4.MenuManager = Me.RibbonControl
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(149, 20)
        Me.TextEdit4.TabIndex = 7
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(6, 35)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl8.TabIndex = 6
        Me.LabelControl8.Text = "PIEZAS:"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(11, 344)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(275, 23)
        Me.SeparatorControl1.TabIndex = 10
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 481)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(301, 94)
        Me.GroupControl1.TabIndex = 9
        Me.GroupControl1.Text = "TOTALES"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(101, 54)
        Me.TextEdit2.MenuManager = Me.RibbonControl
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(149, 20)
        Me.TextEdit2.TabIndex = 9
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(6, 61)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "TOTAL:"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(101, 28)
        Me.TextEdit1.MenuManager = Me.RibbonControl
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(149, 20)
        Me.TextEdit1.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(6, 35)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "SUBTOTAL:"
        '
        'CB_ALMACEN
        '
        Me.CB_ALMACEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_ALMACEN.FormattingEnabled = True
        Me.CB_ALMACEN.Location = New System.Drawing.Point(187, 286)
        Me.CB_ALMACEN.Name = "CB_ALMACEN"
        Me.CB_ALMACEN.Size = New System.Drawing.Size(122, 21)
        Me.CB_ALMACEN.TabIndex = 8
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(187, 267)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "ALMACEN"
        '
        'DT_FECHA
        '
        Me.DT_FECHA.EditValue = Nothing
        Me.DT_FECHA.Location = New System.Drawing.Point(8, 287)
        Me.DT_FECHA.MenuManager = Me.RibbonControl
        Me.DT_FECHA.Name = "DT_FECHA"
        Me.DT_FECHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DT_FECHA.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DT_FECHA.Size = New System.Drawing.Size(149, 20)
        Me.DT_FECHA.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 268)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "FECHA"
        '
        'CB_PROVIDER
        '
        Me.CB_PROVIDER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_PROVIDER.FormattingEnabled = True
        Me.CB_PROVIDER.Location = New System.Drawing.Point(8, 223)
        Me.CB_PROVIDER.Name = "CB_PROVIDER"
        Me.CB_PROVIDER.Size = New System.Drawing.Size(301, 21)
        Me.CB_PROVIDER.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(8, 204)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "PROVEEDOR"
        '
        'TXT_T_COMPRA
        '
        Me.TXT_T_COMPRA.EditValue = "DIRECTA"
        Me.TXT_T_COMPRA.Location = New System.Drawing.Point(8, 166)
        Me.TXT_T_COMPRA.MenuManager = Me.RibbonControl
        Me.TXT_T_COMPRA.Name = "TXT_T_COMPRA"
        Me.TXT_T_COMPRA.Properties.ReadOnly = True
        Me.TXT_T_COMPRA.Size = New System.Drawing.Size(149, 20)
        Me.TXT_T_COMPRA.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 147)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "TIPO DE COMPRA"
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(8, 14)
        Me.TXT_ID.MenuManager = Me.RibbonControl
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Properties.ReadOnly = True
        Me.TXT_ID.Size = New System.Drawing.Size(100, 20)
        Me.TXT_ID.TabIndex = 0
        '
        'dgv_data
        '
        Me.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cantidad, Me.col_clave, Me.col_accesorio, Me.col_material, Me.col_linea, Me.col_descripcion, Me.col_costo_unit, Me.col_precio_pub, Me.col_importe})
        Me.dgv_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_data.Location = New System.Drawing.Point(346, 143)
        Me.dgv_data.Name = "dgv_data"
        Me.dgv_data.Size = New System.Drawing.Size(797, 649)
        Me.dgv_data.TabIndex = 7
        '
        'col_cantidad
        '
        Me.col_cantidad.HeaderText = "CANTIDAD"
        Me.col_cantidad.Name = "col_cantidad"
        Me.col_cantidad.Width = 84
        '
        'col_clave
        '
        Me.col_clave.HeaderText = "CLAVE"
        Me.col_clave.Name = "col_clave"
        Me.col_clave.Width = 63
        '
        'col_accesorio
        '
        Me.col_accesorio.HeaderText = "ACCESORIO"
        Me.col_accesorio.Name = "col_accesorio"
        Me.col_accesorio.Width = 92
        '
        'col_material
        '
        Me.col_material.HeaderText = "MATERIAL"
        Me.col_material.Name = "col_material"
        Me.col_material.Width = 82
        '
        'col_linea
        '
        Me.col_linea.HeaderText = "LINEA"
        Me.col_linea.Name = "col_linea"
        Me.col_linea.Width = 61
        '
        'col_descripcion
        '
        Me.col_descripcion.HeaderText = "DESCRIPCION"
        Me.col_descripcion.Name = "col_descripcion"
        Me.col_descripcion.Width = 101
        '
        'col_costo_unit
        '
        Me.col_costo_unit.HeaderText = "COSTO UNITARIO"
        Me.col_costo_unit.Name = "col_costo_unit"
        Me.col_costo_unit.Width = 110
        '
        'col_precio_pub
        '
        Me.col_precio_pub.HeaderText = "PRECIO PUBLICO"
        Me.col_precio_pub.Name = "col_precio_pub"
        Me.col_precio_pub.Width = 106
        '
        'col_importe
        '
        Me.col_importe.HeaderText = "IMPORTE"
        Me.col_importe.Name = "col_importe"
        Me.col_importe.Width = 77
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(131, 60)
        Me.TextEdit5.MenuManager = Me.RibbonControl
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit5.Properties.Appearance.Options.UseFont = True
        Me.TextEdit5.Size = New System.Drawing.Size(197, 30)
        Me.TextEdit5.TabIndex = 12
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(14, 77)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl9.TabIndex = 11
        Me.LabelControl9.Text = "CLAVE DEL PRODUCTO"
        '
        'frm_compras
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 823)
        Me.Controls.Add(Me.dgv_data)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frm_compras"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "COMPRAS"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_FECHA.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_FECHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_T_COMPRA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BTN_SAVE As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BTN_DELETE_ROW_SELEC As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BTN_DELETE As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents TXT_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TXT_T_COMPRA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CB_PROVIDER As ComboBox
    Friend WithEvents DT_FECHA As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CB_ALMACEN As ComboBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LBL_RESULT_PROVIDER As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents LBL_RESULT_WAREH As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents dgv_data As DataGridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_cantidad As DataGridViewTextBoxColumn
    Friend WithEvents col_clave As DataGridViewTextBoxColumn
    Friend WithEvents col_accesorio As DataGridViewTextBoxColumn
    Friend WithEvents col_material As DataGridViewTextBoxColumn
    Friend WithEvents col_linea As DataGridViewTextBoxColumn
    Friend WithEvents col_descripcion As DataGridViewTextBoxColumn
    Friend WithEvents col_costo_unit As DataGridViewTextBoxColumn
    Friend WithEvents col_precio_pub As DataGridViewTextBoxColumn
    Friend WithEvents col_importe As DataGridViewTextBoxColumn
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
