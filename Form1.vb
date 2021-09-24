Public Class Form1
    Private Sub NewtablesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles NewtablesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NewtablesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SampleDBDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SampleDBDataSet.Newtables' table. You can move, or remove it, as needed.
        Me.NewtablesTableAdapter.Fill(Me.SampleDBDataSet.Newtables)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
