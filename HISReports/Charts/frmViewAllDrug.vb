Imports System.Drawing.Drawing2D
Public Class frmViewAllDrug
    Public selected As String
    Public issave As Boolean
    Private Sub frmViewAllDrug_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewallDrug()
        Me.KeyPreview = True
        Me.txtsearch.Select()
        Me.txtsearch.Focus()
        Me.btnIgnoreCreateNew.Image = modGlobal.load_item_icon
        Me.ToolStripButton1.Image = modGlobal.select_record_icon
        Me.ToolStripButton2.Image = modGlobal.close_icon
    End Sub
    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If Me.DataGridView1.Rows.Count > 0 Then
            If e.RowIndex <> -1 Then
                selected = Me.DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells(0).Value
                issave = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        selected = Me.DataGridView1.SelectedRows(0).Cells(0).Value
        issave = True
        Me.Close()
    End Sub
    Private Sub paintForm(ByVal sender As Object, ByVal e As PaintEventArgs) 'Handles MyBase.Paint
        Dim mGraphics As Graphics = e.Graphics
        Dim pen1 As Pen = New Pen(Color.FromArgb(252, 254, 255), 1)
        Dim Area1 As Rectangle = New Rectangle(0, 0, Me.Width - 1, Me.Height - 1) '253, 254, 255
        Dim LGB As LinearGradientBrush = New LinearGradientBrush(Area1, Color.FromArgb(252, 254, 255), Color.ForestGreen, LinearGradientMode.Vertical)
        mGraphics.FillRectangle(LGB, Area1)
        mGraphics.DrawRectangle(pen1, Area1)
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        issave = False
        Me.Close()
    End Sub
    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        If Me.chkfastersearching.Checked Then
            viewallDrug()
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        viewallDrug()
    End Sub
    Private Sub viewallDrug()
        Me.DataGridView1.Rows.Clear()
        Dim dt = clsDashboard.getMyPatients(14, Me.txtsearch.Text)

        For ctr = 0 To dt.Rows.Count - 1
            Me.DataGridView1.Rows.Add(1)
            Me.DataGridView1.Rows(ctr).Cells(0).Value = dt.Rows(ctr)("Item Code").ToString()
            Me.DataGridView1.Rows(ctr).Cells(1).Value = dt.Rows(ctr)("Brand Name").ToString()
            'Me.DataGridView1.Rows(ctr).Cells(2).Value = dt.Rows(ctr)("Stats").ToString()
            'If dt.Rows(ctr)("Stats").ToString() = "Available" Then
            '    Me.DataGridView1.Rows(ctr).Cells(2).Style.ForeColor = Color.Green
            '    Me.DataGridView1.Rows(ctr).Cells(2).Style.SelectionForeColor = Color.Green
            'Else
            '    Me.DataGridView1.Rows(ctr).Cells(2).Style.ForeColor = Color.Red
            '    Me.DataGridView1.Rows(ctr).Cells(2).Style.SelectionForeColor = Color.Red
            'End If
            Me.DataGridView1.Rows(ctr).Cells(2).Value = dt.Rows(ctr)("Generic Name").ToString()
        Next
        Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView1.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        Me.DataGridView1.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        'Me.DataGridView1.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub frmViewAllDrug_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            viewallDrug()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub chkfastersearching_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkfastersearching.CheckedChanged
        If Me.chkfastersearching.Checked Then
            viewallDrug()
        End If
    End Sub

    Private Sub DataGridView1_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.ColumnIndex = 3 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim bmpFind As Bitmap = ImageList1.Images(0)
            Dim ico As Icon = Icon.FromHandle(bmpFind.GetHicon)
            e.Graphics.DrawIcon(ico, e.CellBounds.Left + 8, e.CellBounds.Top + 12)
            e.Handled = True
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells(3).Selected = True And Me.DataGridView1.CurrentCell.ColumnIndex.Equals(3) And e.RowIndex <> -1 Then
                selected = Me.DataGridView1.Rows(Me.DataGridView1.CurrentRow.Index).Cells(0).Value
                issave = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnIgnoreCreateNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgnoreCreateNew.Click
        Dim frm As New frmItems
        frm.myFormStatus = frmItems.enFormStatus.add
        frm.ShowDialog()
        viewallDrug()
    End Sub
End Class