Imports System.Drawing.Drawing2D
Public Class frmPrescriptionTemplates
    Dim dtRecord As New DataTable()
    Public ok As Boolean
    Private Sub frmPrescriptionTemplates_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel1.Text = modGlobal.msgboxTitle & " ©" & Utility.GetServerDate().Year
        Me.KeyPreview = True
        Call DisplayList()
        Me.txtPrescription.Select()
        Me.txtPrescription.Focus()
        Me.ToolStripButton1.Image = modGlobal.save_icon
        Me.tsClose.Image = modGlobal.close_icon
    End Sub

    Private Sub DisplayList()
        Me.dgvListOfPrescription.Rows.Clear()
        dtRecord = clsDashboard.getMyPatients(10, Me.txtPrescription.Text, 0, modGlobal.employeeid)
        For ctr = 0 To dtRecord.Rows.Count - 1
            Me.dgvListOfPrescription.Rows.Add(1)
            Me.dgvListOfPrescription.Rows(ctr).Cells(0).Value = dtRecord.Rows(ctr).Item("prescriptionid").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(1).Value = dtRecord.Rows(ctr).Item("id").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(2).Value = dtRecord.Rows(ctr).Item("name").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(3).Value = dtRecord.Rows(ctr).Item("Owner").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(4).Value = dtRecord.Rows(ctr).Item("Drug Name").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(5).Value = dtRecord.Rows(ctr).Item("frequency").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(6).Value = dtRecord.Rows(ctr).Item("dosage").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(7).Value = dtRecord.Rows(ctr).Item("period").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(8).Value = dtRecord.Rows(ctr).Item("quantity").ToString()
            'Me.dgvListOfPrescription.Rows(ctr).Cells(8).Value = "Add"
            Me.dgvListOfPrescription.Rows(ctr).Cells(10).Value = dtRecord.Rows(ctr).Item("dc").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(11).Value = dtRecord.Rows(ctr).Item("pd").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(12).Value = dtRecord.Rows(ctr).Item("pr").ToString()
            Me.dgvListOfPrescription.Rows(ctr).Cells(13).Value = Utility.NullToZero(dtRecord.Rows(ctr).Item("frequencyid"))
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsClose.Click
        ok = False
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call DisplayList()
    End Sub
    Private Sub paintForm(ByVal sender As Object, ByVal e As PaintEventArgs) ' Handles MyBase.Paint
        Dim mGraphics As Graphics = e.Graphics
        Dim pen1 As Pen = New Pen(Color.FromArgb(252, 254, 255), 1)
        Dim Area1 As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1) '253, 254, 255
        Dim LGB As LinearGradientBrush = New LinearGradientBrush(Area1, Color.FromArgb(252, 254, 255), Color.ForestGreen, LinearGradientMode.Vertical)
        mGraphics.FillRectangle(LGB, Area1)
        mGraphics.DrawRectangle(pen1, Area1)
    End Sub
    Private Sub dgvListOfPrescription_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListOfPrescription.CellContentClick
        If Me.dgvListOfPrescription.Rows.Count > 0 Then
            If Me.dgvListOfPrescription.CurrentCell.ColumnIndex.Equals(9) And e.RowIndex <> -1 Then
                ok = True
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub dgvListOfPrescription_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvListOfPrescription.CellPainting
        If e.ColumnIndex = 9 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim bmpFind As Bitmap = ImageList1.Images(0)
            Dim ico As Icon = Icon.FromHandle(bmpFind.GetHicon)
            e.Graphics.DrawIcon(ico, e.CellBounds.Left + 9, e.CellBounds.Top + 5.5)
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

    End Sub

    Private Sub frmPrescriptionTemplates_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call DisplayList()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class