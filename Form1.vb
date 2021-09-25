Public Class Form1
    Private Sub NewtablesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles NewtablesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NewtablesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SampleDBDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SampleDBDataSet.Newtables' table. You can move, or remove it, as needed.
        Me.NewtablesTableAdapter.Fill(Me.SampleDBDataSet.Newtables)
        Timer1.Start()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewtablesBindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            NewtablesBindingSource.EndEdit()
            NewtablesTableAdapter.Update(SampleDBDataSet.Newtables)
            MessageBox.Show("Data Saved")
        Catch ex As Exception
            MessageBox.Show("didn't saved")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NewtablesBindingSource.RemoveCurrent()
    End Sub

    Private Sub NewQueryToolStripButton_Click(sender As Object, e As EventArgs) Handles NewQueryToolStripButton.Click
        Try
            Me.NewtablesTableAdapter.newQuery(Me.SampleDBDataSet.Newtables)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim count As Integer
        count = NewtablesBindingSource.Count
        Label1.Text = " The No of Records = " + count.ToString


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
