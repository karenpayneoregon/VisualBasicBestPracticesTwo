Namespace LanguageExtensions
    Public Module ControlExtensions
        ''' <summary>
        ''' Get list of TextBox on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of TextBox or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function TextBoxList(pControl As Control) As List(Of TextBox)
            Return pControl.Descendants(Of TextBox)().ToList()
        End Function
        ''' <summary>
        ''' Get list of Label on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of Label or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function LabelList(pControl As Control) As List(Of Label)
            Return pControl.Descendants(Of Label)().ToList()
        End Function
        ''' <summary>
        ''' Get list of CheckBox on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of CheckBox or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function CheckBoxList(pControl As Control) As List(Of CheckBox)
            Return pControl.Descendants(Of CheckBox)().ToList()
        End Function
        ''' <summary>
        ''' Get list of DataGridView on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of DataGridView or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function DataGridViewList(pControl As Control) As List(Of DataGridView)
            Return pControl.Descendants(Of DataGridView)().ToList()
        End Function
        ''' <summary>
        ''' Get list of ComboBox on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of ComboBox or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function ComboBoxList(pControl As Control) As List(Of ComboBox)
            Return pControl.Descendants(Of ComboBox)().ToList()
        End Function
        ''' <summary>
        ''' Get list of ListBox on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of ListBox or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function ListBoxList(pControl As Control) As List(Of ListBox)
            Return pControl.Descendants(Of ListBox)().ToList()
        End Function
        ''' <summary>
        ''' Get list of DateTimePicker on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of DateTimePicker or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function DateTimePickerList(pControl As Control) As List(Of DateTimePicker)
            Return pControl.Descendants(Of DateTimePicker)().ToList()
        End Function
        ''' <summary>
        ''' Get list of PictureBox on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of PictureBox or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function PictureBoxList(pControl As Control) As List(Of PictureBox)
            Return pControl.Descendants(Of PictureBox)().ToList()
        End Function
        ''' <summary>
        ''' Get list of Panel on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of Panel or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function PanelList(pControl As Control) As List(Of Panel)
            Return pControl.Descendants(Of Panel)().ToList()
        End Function
        ''' <summary>
        ''' Get list of GroupBox on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of GroupBox or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function GroupBoxList(pControl As Control) As List(Of GroupBox)
            Return pControl.Descendants(Of GroupBox)().ToList()
        End Function
        ''' <summary>
        ''' Get list of ListView on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of ListView or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function ListViewList(pControl As Control) As List(Of ListView)
            Return pControl.Descendants(Of ListView)().ToList()
        End Function
        ''' <summary>
        ''' Get list of Button on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of Button or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function ButtonList(pControl As Control) As List(Of Button)
            Return pControl.Descendants(Of Button)().ToList()
        End Function
        <Runtime.CompilerServices.Extension>
        Public Function RadioButtonList(pControl As Control) As List(Of RadioButton)
            Return pControl.Descendants(Of RadioButton)().ToList()
        End Function
        ''' <summary>
        ''' Get selected RadioButton
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <param name="pChecked">True to get checked</param>
        ''' <returns>Get selected RadioButton</returns>
        <Runtime.CompilerServices.Extension>
        Public Function RadioButtonChecked(pControl As Control, Optional pChecked As Boolean = True) As RadioButton
            Return pControl.Descendants(Of RadioButton)().ToList().FirstOrDefault(Function(radioButton) radioButton.Checked = pChecked)
        End Function
        ''' <summary>
        ''' Get list of NumericUpDown on control
        ''' </summary>
        ''' <param name="pControl">Control to find controls on</param>
        ''' <returns>List of NumericUpDown or empty list</returns>
        <Runtime.CompilerServices.Extension>
        Public Function NumericUpDownList(pControl As Control) As List(Of NumericUpDown)
            Return pControl.Descendants(Of NumericUpDown)().ToList()
        End Function
        ''' <summary>
        ''' Get names of controls 
        ''' </summary>
        ''' <param name="pControls"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension>
        Public Function ControlNames(pControls As IEnumerable(Of Control)) As String()
            Return pControls.Select(Function(c) c.Name).ToArray()
        End Function
        ''' <summary>
        ''' Is control a container
        ''' </summary>
        ''' <param name="pControl"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension>
        Public Function IsContainer(pControl As Control) As Boolean
            Return pControl.HasChildren
        End Function
    End Module
End NameSpace