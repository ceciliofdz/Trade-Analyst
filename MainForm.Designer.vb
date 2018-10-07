Imports System.IO
Imports System.String
'
' Creado por SharpDevelop.
' Usuario: Cecilio
' Fecha: 14/09/2018
' Hora: 20:46
' 
' Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Me.bto_preview = New System.Windows.Forms.Button()
		Me.txt_stock = New System.Windows.Forms.RichTextBox()
		Me.bto_download = New System.Windows.Forms.Button()
		Me.bto_market = New System.Windows.Forms.Button()
		Me.bto_new = New System.Windows.Forms.Button()
		Me.bto_exit = New System.Windows.Forms.Button()
		Me.label1 = New System.Windows.Forms.Label()
		Me.txt_find = New System.Windows.Forms.TextBox()
		Me.bto_find = New System.Windows.Forms.Button()
		Me.label2 = New System.Windows.Forms.Label()
		Me.combo_stock = New System.Windows.Forms.ComboBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.combo_market = New System.Windows.Forms.ComboBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.gro_days = New System.Windows.Forms.GroupBox()
		Me.rad_total = New System.Windows.Forms.RadioButton()
		Me.rad_100 = New System.Windows.Forms.RadioButton()
		Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.tul_text = New System.Windows.Forms.ToolStripStatusLabel()
		Me.gro_adjus = New System.Windows.Forms.GroupBox()
		Me.rad_no = New System.Windows.Forms.RadioButton()
		Me.rad_yes = New System.Windows.Forms.RadioButton()
		Me.gro_Period = New System.Windows.Forms.GroupBox()
		Me.rad_monthly = New System.Windows.Forms.RadioButton()
		Me.rad_weekly = New System.Windows.Forms.RadioButton()
		Me.rad_daily = New System.Windows.Forms.RadioButton()
		Me.gro_days.SuspendLayout
		Me.statusStrip1.SuspendLayout
		Me.gro_adjus.SuspendLayout
		Me.gro_Period.SuspendLayout
		Me.SuspendLayout
		'
		'bto_preview
		'
		Me.bto_preview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bto_preview.Location = New System.Drawing.Point(18, 352)
		Me.bto_preview.Name = "bto_preview"
		Me.bto_preview.Size = New System.Drawing.Size(129, 23)
		Me.bto_preview.TabIndex = 0
		Me.bto_preview.Text = "Preview Stock"
		Me.bto_preview.UseVisualStyleBackColor = true
		AddHandler Me.bto_preview.Click, AddressOf Me.Bto_previewClick
		'
		'txt_stock
		'
		Me.txt_stock.Location = New System.Drawing.Point(18, 150)
		Me.txt_stock.Name = "txt_stock"
		Me.txt_stock.Size = New System.Drawing.Size(463, 183)
		Me.txt_stock.TabIndex = 1
		Me.txt_stock.Text = ""
		'
		'bto_download
		'
		Me.bto_download.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bto_download.Location = New System.Drawing.Point(191, 352)
		Me.bto_download.Name = "bto_download"
		Me.bto_download.Size = New System.Drawing.Size(129, 23)
		Me.bto_download.TabIndex = 2
		Me.bto_download.Text = "Download stock"
		Me.bto_download.UseVisualStyleBackColor = true
		AddHandler Me.bto_download.Click, AddressOf Me.Bto_downloadClick
		'
		'bto_market
		'
		Me.bto_market.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bto_market.Location = New System.Drawing.Point(352, 352)
		Me.bto_market.Name = "bto_market"
		Me.bto_market.Size = New System.Drawing.Size(129, 23)
		Me.bto_market.TabIndex = 3
		Me.bto_market.Text = "Download Market"
		Me.bto_market.UseVisualStyleBackColor = true
		AddHandler Me.bto_market.Click, AddressOf Me.Bto_marketClick
		'
		'bto_new
		'
		Me.bto_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bto_new.Location = New System.Drawing.Point(504, 310)
		Me.bto_new.Name = "bto_new"
		Me.bto_new.Size = New System.Drawing.Size(108, 23)
		Me.bto_new.TabIndex = 4
		Me.bto_new.Text = "New"
		Me.bto_new.UseVisualStyleBackColor = true
		AddHandler Me.bto_new.Click, AddressOf Me.Bto_newClick
		'
		'bto_exit
		'
		Me.bto_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bto_exit.Location = New System.Drawing.Point(504, 352)
		Me.bto_exit.Name = "bto_exit"
		Me.bto_exit.Size = New System.Drawing.Size(108, 23)
		Me.bto_exit.TabIndex = 5
		Me.bto_exit.Text = "Exit"
		Me.bto_exit.UseVisualStyleBackColor = true
		AddHandler Me.bto_exit.Click, AddressOf Me.Bto_exitClick
		'
		'label1
		'
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(18, 124)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(161, 23)
		Me.label1.TabIndex = 6
		Me.label1.Text = "Logs / Preview stock file."
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'txt_find
		'
		Me.txt_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.txt_find.Location = New System.Drawing.Point(18, 56)
		Me.txt_find.Name = "txt_find"
		Me.txt_find.Size = New System.Drawing.Size(155, 21)
		Me.txt_find.TabIndex = 7
		'
		'bto_find
		'
		Me.bto_find.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.bto_find.Location = New System.Drawing.Point(179, 56)
		Me.bto_find.Name = "bto_find"
		Me.bto_find.Size = New System.Drawing.Size(57, 23)
		Me.bto_find.TabIndex = 8
		Me.bto_find.Text = "Find"
		Me.bto_find.UseVisualStyleBackColor = true
		AddHandler Me.bto_find.Click, AddressOf Me.Bto_findClick
		'
		'label2
		'
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label2.Location = New System.Drawing.Point(18, 30)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 9
		Me.label2.Text = "Find an stock?"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'combo_stock
		'
		Me.combo_stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.combo_stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.combo_stock.FormattingEnabled = true
		Me.combo_stock.Location = New System.Drawing.Point(251, 56)
		Me.combo_stock.Name = "combo_stock"
		Me.combo_stock.Size = New System.Drawing.Size(92, 21)
		Me.combo_stock.TabIndex = 10
		AddHandler Me.combo_stock.SelectedIndexChanged, AddressOf Me.Combo_stockSelectedIndexChanged
		'
		'label3
		'
		Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label3.Location = New System.Drawing.Point(251, 29)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(69, 23)
		Me.label3.TabIndex = 11
		Me.label3.Text = "Stock"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'combo_market
		'
		Me.combo_market.FormattingEnabled = true
		Me.combo_market.Location = New System.Drawing.Point(349, 56)
		Me.combo_market.Name = "combo_market"
		Me.combo_market.Size = New System.Drawing.Size(102, 21)
		Me.combo_market.TabIndex = 12
		AddHandler Me.combo_market.SelectionChangeCommitted, AddressOf Me.Combo_marketSelectionChangeCommitted
		AddHandler Me.combo_market.KeyPress, AddressOf Me.Combo_marketKeyPress
		'
		'label4
		'
		Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label4.Location = New System.Drawing.Point(349, 29)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(74, 23)
		Me.label4.TabIndex = 13
		Me.label4.Text = "Market"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'gro_days
		'
		Me.gro_days.Controls.Add(Me.rad_total)
		Me.gro_days.Controls.Add(Me.rad_100)
		Me.gro_days.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gro_days.Location = New System.Drawing.Point(496, 12)
		Me.gro_days.Name = "gro_days"
		Me.gro_days.Size = New System.Drawing.Size(150, 85)
		Me.gro_days.TabIndex = 14
		Me.gro_days.TabStop = false
		Me.gro_days.Text = "Days"
		'
		'rad_total
		'
		Me.rad_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rad_total.Location = New System.Drawing.Point(12, 44)
		Me.rad_total.Name = "rad_total"
		Me.rad_total.Size = New System.Drawing.Size(133, 24)
		Me.rad_total.TabIndex = 1
		Me.rad_total.TabStop = true
		Me.rad_total.Text = "Total (20 years)"
		Me.rad_total.UseVisualStyleBackColor = true
		'
		'rad_100
		'
		Me.rad_100.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.rad_100.Location = New System.Drawing.Point(12, 14)
		Me.rad_100.Name = "rad_100"
		Me.rad_100.Size = New System.Drawing.Size(123, 24)
		Me.rad_100.TabIndex = 0
		Me.rad_100.TabStop = true
		Me.rad_100.Text = "100 (Default)"
		Me.rad_100.UseVisualStyleBackColor = true
		'
		'statusStrip1
		'
		Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tul_text})
		Me.statusStrip1.Location = New System.Drawing.Point(0, 406)
		Me.statusStrip1.Name = "statusStrip1"
		Me.statusStrip1.Size = New System.Drawing.Size(658, 22)
		Me.statusStrip1.TabIndex = 15
		Me.statusStrip1.Text = "statusStrip1"
		'
		'tul_text
		'
		Me.tul_text.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.tul_text.Name = "tul_text"
		Me.tul_text.Size = New System.Drawing.Size(643, 17)
		Me.tul_text.Spring = true
		Me.tul_text.Text = "log"
		'
		'gro_adjus
		'
		Me.gro_adjus.Controls.Add(Me.rad_no)
		Me.gro_adjus.Controls.Add(Me.rad_yes)
		Me.gro_adjus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gro_adjus.Location = New System.Drawing.Point(496, 103)
		Me.gro_adjus.Name = "gro_adjus"
		Me.gro_adjus.Size = New System.Drawing.Size(150, 50)
		Me.gro_adjus.TabIndex = 16
		Me.gro_adjus.TabStop = false
		Me.gro_adjus.Text = "Adjusted"
		'
		'rad_no
		'
		Me.rad_no.Location = New System.Drawing.Point(73, 20)
		Me.rad_no.Name = "rad_no"
		Me.rad_no.Size = New System.Drawing.Size(55, 24)
		Me.rad_no.TabIndex = 1
		Me.rad_no.TabStop = true
		Me.rad_no.Text = "No"
		Me.rad_no.UseVisualStyleBackColor = true
		'
		'rad_yes
		'
		Me.rad_yes.Location = New System.Drawing.Point(12, 20)
		Me.rad_yes.Name = "rad_yes"
		Me.rad_yes.Size = New System.Drawing.Size(104, 24)
		Me.rad_yes.TabIndex = 0
		Me.rad_yes.TabStop = true
		Me.rad_yes.Text = "Yes"
		Me.rad_yes.UseVisualStyleBackColor = true
		'
		'gro_Period
		'
		Me.gro_Period.Controls.Add(Me.rad_monthly)
		Me.gro_Period.Controls.Add(Me.rad_weekly)
		Me.gro_Period.Controls.Add(Me.rad_daily)
		Me.gro_Period.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.gro_Period.Location = New System.Drawing.Point(496, 172)
		Me.gro_Period.Name = "gro_Period"
		Me.gro_Period.Size = New System.Drawing.Size(150, 113)
		Me.gro_Period.TabIndex = 17
		Me.gro_Period.TabStop = false
		Me.gro_Period.Text = "Period"
		'
		'rad_monthly
		'
		Me.rad_monthly.Location = New System.Drawing.Point(6, 78)
		Me.rad_monthly.Name = "rad_monthly"
		Me.rad_monthly.Size = New System.Drawing.Size(85, 23)
		Me.rad_monthly.TabIndex = 2
		Me.rad_monthly.TabStop = true
		Me.rad_monthly.Text = "Monthly"
		Me.rad_monthly.UseVisualStyleBackColor = true
		'
		'rad_weekly
		'
		Me.rad_weekly.Location = New System.Drawing.Point(6, 48)
		Me.rad_weekly.Name = "rad_weekly"
		Me.rad_weekly.Size = New System.Drawing.Size(73, 24)
		Me.rad_weekly.TabIndex = 1
		Me.rad_weekly.TabStop = true
		Me.rad_weekly.Text = "Weekly"
		Me.rad_weekly.UseVisualStyleBackColor = true
		'
		'rad_daily
		'
		Me.rad_daily.Location = New System.Drawing.Point(6, 18)
		Me.rad_daily.Name = "rad_daily"
		Me.rad_daily.Size = New System.Drawing.Size(64, 24)
		Me.rad_daily.TabIndex = 0
		Me.rad_daily.TabStop = true
		Me.rad_daily.Text = "Daily"
		Me.rad_daily.UseVisualStyleBackColor = true
		'
		'MainForm
		'
		Me.AcceptButton = Me.bto_find
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(658, 428)
		Me.Controls.Add(Me.gro_Period)
		Me.Controls.Add(Me.gro_adjus)
		Me.Controls.Add(Me.statusStrip1)
		Me.Controls.Add(Me.gro_days)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.combo_market)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.combo_stock)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.bto_find)
		Me.Controls.Add(Me.txt_find)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.bto_exit)
		Me.Controls.Add(Me.bto_new)
		Me.Controls.Add(Me.bto_market)
		Me.Controls.Add(Me.bto_download)
		Me.Controls.Add(Me.txt_stock)
		Me.Controls.Add(Me.bto_preview)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.MaximizeBox = false
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Download stock the Alpha Vantage"
		AddHandler Activated, AddressOf Me.MainFormActivated
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.gro_days.ResumeLayout(false)
		Me.statusStrip1.ResumeLayout(false)
		Me.statusStrip1.PerformLayout
		Me.gro_adjus.ResumeLayout(false)
		Me.gro_Period.ResumeLayout(false)
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private rad_daily As System.Windows.Forms.RadioButton
	Private rad_weekly As System.Windows.Forms.RadioButton
	Private rad_monthly As System.Windows.Forms.RadioButton
	Private gro_Period As System.Windows.Forms.GroupBox
	Private rad_no As System.Windows.Forms.RadioButton
	Private rad_yes As System.Windows.Forms.RadioButton
	Private gro_adjus As System.Windows.Forms.GroupBox
	Private tul_text As System.Windows.Forms.ToolStripStatusLabel
	Private statusStrip1 As System.Windows.Forms.StatusStrip
	Private rad_100 As System.Windows.Forms.RadioButton
	Private rad_total As System.Windows.Forms.RadioButton
	Private gro_days As System.Windows.Forms.GroupBox
	Private label4 As System.Windows.Forms.Label
	Private combo_market As System.Windows.Forms.ComboBox
	Private label3 As System.Windows.Forms.Label
	Private combo_stock As System.Windows.Forms.ComboBox
	Private label2 As System.Windows.Forms.Label
	Private bto_find As System.Windows.Forms.Button
	Private txt_find As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private bto_exit As System.Windows.Forms.Button
	Private bto_new As System.Windows.Forms.Button
	Private bto_market As System.Windows.Forms.Button
	Private bto_download As System.Windows.Forms.Button
	Private txt_stock As System.Windows.Forms.RichTextBox
	Private bto_preview As System.Windows.Forms.Button
	
	
	Sub Bto_exitClick(sender As Object, e As EventArgs)
		 Dim Msg As MsgBoxResult
        Msg = MsgBox("Close app, exit?", vbYesNo, "Download stock the Alpha Vantage")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If
		
	End Sub
	
	Sub MainFormActivated(sender As Object, e As EventArgs)
		
		txt_find.Select()
		rad_100.Checked = True
		rad_total.Checked = False
		rad_yes.Checked = False
		rad_no.Checked = True
		rad_daily.Checked = True
		rad_weekly.Checked = False
		rad_monthly.Checked = False
		
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		
		Dim Filename As String
		rad_100.Checked=True
		' delete all existing choices
		combo_market.Items.Clear
		combo_stock.Items.Clear
		Filename= "data\index.csv"
		cargarcombo(combo_market,Filename)
		'MsgBox(Filename,MsgBoxStyle.OkOnly)
		cargarcombo(combo_stock,System.String.Concat("data\",combo_market.SelectedItem, ".csv"))
		txt_find.Text=combo_stock.SelectedItem.ToString
		
		
	End Sub
	
	
	Sub cargarcombo(combo As System.Windows.Forms.ComboBox, fichero As String) 
		Dim f As IO.StreamReader
		Dim reg As String()

        f = IO.File.OpenText(fichero)
        Do Until f.EndOfStream
        	
        	reg = f.ReadLine().Split(New Char() {";"c})
        	If (reg(0)<>"Ticker") Then
        		combo.Items.Add(reg(0))
        	End If
        Loop
        f.Close()
        combo.Text=combo.Items(0).ToString
        
	End Sub
	
	Public Function leerHtml(ByVal Url As String) As String
        Dim WR As System.Net.WebRequest
        Dim Rsp As System.Net.WebResponse
        WR = System.Net.WebRequest.Create(Url)
        WR.Proxy= System.Net.WebProxy.GetDefaultProxy()
        Rsp = WR.GetResponse()
        Return New StreamReader(Rsp.GetResponseStream()).ReadToEnd()
	End Function 
	
	Public Function api(val As String) As String
		
		Dim qapi, nprod,val_csv As String
		Dim funcion,total,ajuste As String
		
		ajuste=""
		funcion=""
		
		If ( rad_total.Checked) Then
			total="&outputsize=full"
     		'qapi = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY_ADJUSTED&symbol=%valor&outputsize=full&apikey=8FQFHRYJK498897C&datatype=csv"
		Else
			total=""
      		'qapi = "https://www.alphavantage.co/query?function=TIME_SERIES_DAILY_ADJUSTED&symbol=%valor&apikey=8FQFHRYJK498897C&datatype=csv"
  		End If
  		
  		If (rad_yes.Checked) Then
  			ajuste= "_ADJUSTED"
  		End If
  		
  		If (rad_daily.Checked) Then
  			
  			funcion = System.String.Concat("TIME_SERIES_DAILY",ajuste)
  			
  		End If
  		
  		If (rad_weekly.Checked) Then
  			
  			funcion = System.String.Concat("TIME_SERIES_WEEKLY",ajuste)
  			total=""
  			
  		End If
  		
  		If (rad_monthly.Checked) Then
  			
  			funcion = System.String.Concat("TIME_SERIES_MONTHLY",ajuste)
  			total=""
  			
  		End If

  		
  		
  		qapi = System.String.Concat("https://www.alphavantage.co/query?function=",funcion,"&symbol=%valor",total,"&apikey=8FQFHRYJK498897C&datatype=csv")
  		
  		nprod = qapi.Replace("%valor", val)
  		
  		val_csv = leerHtml(nprod)
  		
  		If (val_csv.IndexOf("Invalid") <> -1) Then
  			'txt_stock.Clear
  			'MsgBox("Error the stock is incorrected",MsgBoxStyle.OkOnly,"Download stock the Alpha Vantage")
  			MessageBox.Show("Error the stock is incorrected","Download stock the Alpha Vantage",MessageBoxButtons.OK, _
            MessageBoxIcon.Exclamation, _
            MessageBoxDefaultButton.Button1)
  			Return "-1"
  		Else
  			If (val_csv.IndexOf("premium") <> -1) Then
  				MessageBox.Show("Time out. Try again after a few seconds","Download stock the Alpha Vantage",MessageBoxButtons.OK, _
                MessageBoxIcon.Exclamation, _
                MessageBoxDefaultButton.Button1)
  				Return "-1"
  				
  			End If
  		End If
  		
  		Return val_csv
	End Function
	
	Sub Combo_marketSelectionChangeCommitted(sender As Object, e As EventArgs)
		combo_stock.Items.Clear
		cargarcombo(combo_stock,System.String.Concat("data\" , combo_market.SelectedItem.ToString, ".csv"))
		txt_find.Text=combo_stock.SelectedItem.ToString
		
	End Sub
	
	
	
	Sub Combo_marketKeyPress(sender As Object, e As KeyPressEventArgs)
		e.Handled = True
	End Sub
	
	Sub Bto_previewClick(sender As Object, e As EventArgs)
		Dim texto_url As String
		
		txt_stock.Clear
		texto_url=api(combo_stock.SelectedItem.ToString)
		
		If  texto_url <> "-1" Then
			txt_stock.Text = texto_url
			tul_text.Text = System.String.Concat("Stock: ",combo_stock.SelectedItem.ToString)
		Else
			txt_stock.Text = "Error: Stock no found"
			tul_text.Text = System.String.Concat("Error:",combo_stock.SelectedItem.ToString)
		End If
		
	End Sub
	
	Sub Bto_newClick(sender As Object, e As EventArgs)
		Dim Filename As String
		
		txt_stock.Clear
		txt_find.Clear
		combo_market.Items.Clear
		combo_stock.Items.Clear
		Filename= "data\index.csv"
		cargarcombo(combo_market,Filename)
		'MsgBox(Filename,MsgBoxStyle.OkOnly)
		cargarcombo(combo_stock,System.String.Concat("data\",combo_market.SelectedItem, ".csv"))
		txt_find.Text=combo_stock.SelectedItem.ToString
		tul_text.Text="" 
		txt_find.Select()
		rad_100.Checked = True
		rad_total.Checked = False
		rad_yes.Checked = False
		rad_no.Checked = True
		rad_daily.Checked = True
		rad_weekly.Checked = False
		rad_monthly.Checked = False
		
		
	End Sub
	
	Sub Bto_findClick(sender As Object, e As EventArgs)
		
		Dim pos_i, pos_f As Int32
		Dim buscar,url,nombre As String
		Dim url_yahoo As String = "https://es.finance.yahoo.com/lookup?s=%valor"
		' TODO : Programar la busqueda de valores para que saque la descriptción o el valor
		' DONE : buscar en el fichero de sp500 antes de lanzar la busqueda en internet
		
		' primero miramos en el fichero de valores de cada mercado.
		
		nombre = buscartrade(RTrim(txt_find.Text),combo_market.SelectedItem.ToString)
		
		If (nombre="-1") Then
		
		  buscar = url_yahoo.Replace("%valor", RTrim(txt_find.Text))
	
		  url = leerHtml(buscar)
		  
		pos_i = url.LastIndexOf("data-reactid=""58""")
		If (pos_i = -1 ) Then
			MsgBox(RTrim(txt_find.Text)+" Not found",MsgBoxStyle.OkOnly,"Download stock the Alpha Vantage")
		Else
		
			pos_f = url.IndexOf("<",pos_i)
			nombre = url.Substring(pos_i + 18,pos_f - (pos_i+18))
			'MsgBox(nombre,MsgBoxStyle.OkOnly,"Download stock the Alpha Vantage")
			txt_stock.Text = nombre
			tul_text.Text= nombre
		End If
		Else
			txt_stock.Text = nombre
			tul_text.Text= nombre
			
		End If 
		
	End Sub
	

	
	Sub Combo_stockSelectedIndexChanged(sender As Object, e As EventArgs)
		txt_find.Text=combo_stock.SelectedItem.ToString
		
	End Sub
	
	Sub grabafile(market As String)
	 	
	 	' TODO : añadir control de errores a la descarga del fichero de stock
	 	Dim fichero, valor As String
	 	
		fichero = System.String.Concat("data\target\",market,".csv")
		
		
		tul_text.Text= (System.String.Concat("Escribiendo fichero: ",fichero))
		
		
		valor = api(market)
		
		If valor <> "-1" Then
		
		Using sw As StreamWriter = New StreamWriter(fichero)
			
			sw.Write(valor)
			
		End Using
		
		tul_text.Text = (System.String.Concat("Fichero Creado: ",fichero))
		Else
			MessageBox.Show("Time out. Try again after a few seconds","Download stock the Alpha Vantage",MessageBoxButtons.OK, _
                MessageBoxIcon.Exclamation, _
                MessageBoxDefaultButton.Button1)
		
		End If
	 End Sub
	
	Sub Bto_downloadClick(sender As Object, e As EventArgs)
		
		' TODO : añadir control de errores a la descarga del fichero de stock
		
		grabafile(combo_stock.SelectedItem.ToString)
       
		
	End Sub
	
	
	Sub Bto_marketClick(sender As Object, e As EventArgs)
		
		
		Dim f As IO.StreamReader
		Dim reg As String()
		
		txt_stock.Text = ""

        f = IO.File.OpenText(System.String.Concat("data\",combo_market.SelectedItem.ToString,".csv"))
        Do Until f.EndOfStream
        	
        	reg = f.ReadLine().Split(New Char() {";"c})
        	If (reg(0)<>"Ticker") Then
        		txt_stock.Text=Concat(txt_stock.Text,reg(0),vbCrLf)
        		grabafile(reg(0))
        	End If
        Loop
        f.Close()
       
		
		' TODO : programar la descarga en ficheros csv para su análisis posterior. Descarga todos los valores del market elegido
		
	End Sub
	
	
	
End Class
