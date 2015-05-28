Public Class frmMain
    Dim lcStart As Decimal 'Creating start variable and storing 0 in it.
    Dim lcIncrement As Decimal 'Creating increment variable and storing 0 in it.
    Dim lcEnd As Decimal 'Creating end variable and storing 0 in it.

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboConversionChoice.Items.AddRange(gl_CONVERSION_CHOICES) 'Grab all conversion choices from global array and add them to combobox
        cboConversionChoice.SelectedIndex = 0 'Default setting of grams to ounces
        cboDecimalPlaces.Items.AddRange(gl_DECIMAL_PLACES) 'Grab all decimal place choices from global array and add them to combobox
        cboDecimalPlaces.SelectedIndex = 3 'Default setting of rounding to 3 dp as it is most common
    End Sub

    Private Sub btnConvertValue_Click(sender As Object, e As EventArgs) Handles btnConvertValue.Click 'When we click the convert value button, this subtask will be executed.
        lblResult.Text = "" 'as soon as they click convert value, any exisiting result will be erased
        Dim lcValue As Decimal 'local variable for subtask that stores value. Currently stored as 0.
        If ValidateTextbox(lcValue, txtValue) Then 'If we can put the users input in our decimal variable, we can continue
            Call ConvertValue(lcValue) 'We need to call a separate subtask that deals with converting the user's value to another unit.
            lblResult.Text = lcValue 'We receive the result back from the ConvertValue subtask and display this in a label.
        End If
    End Sub

    Private Sub ConvertValue(ByRef prValue As Decimal) 'This subtask will be run whenever we need to convert a value
        Dim lcIndexNumber As Integer = cboConversionChoice.SelectedIndex 'The selected conversion choice is stored in a variable
        Dim lcFormula As Decimal = gl_CONVERSION_FORMULAS(lcIndexNumber) 'Re-using the chosen index number to find out the formula we need to use
        If (lcIndexNumber = 4) Then 'We need to select Celsius to Fahrenheit as the equation is unique
            prValue = (prValue * lcFormula) + 32 'Formula Celsius to Fahrenheit
        ElseIf (lcIndexNumber = 5) Then 'We need to select Fahrenheit to Celsius as the equation is unique
            prValue = (prValue - 32) / lcFormula 'Formula Fahrenheit to Celsius
        Else 'All the other options use the same equation so we are selecting all remaining options here
            prValue = prValue * lcFormula
        End If
        prValue = Math.Round(prValue, cboDecimalPlaces.SelectedIndex) 'We round the number based on the decimal places specified by the user.
    End Sub

    Private Sub btnProduceTable_Click(sender As Object, e As EventArgs) Handles btnProduceTable.Click 'This subtask will be executed when the user clicks the produce table button.
        frmTableOutput.lvwTableOutput.Items.Clear() 'First, we need to clear the previous results in the table form! (if any)
        '"And also" means that if the first function returns false, we don't need to run any more functions as we already know it has failed the requirements for generating a table of results
        If ValidateTextbox(lcStart, txtStart) AndAlso ValidateTextbox(lcIncrement, txtIncrement) AndAlso ValidateTextbox(lcEnd, txtEnd) AndAlso CheckIfIncrementZero() AndAlso CheckForInfiniteLoop() AndAlso TooManyTableResults() Then 'tests if start, increment and end are valid numbers then we see whether they are suitable for making a table.
            Call GenerateTableOutput() 'If the user's input passes (returns true) all the function tests, we can run the subtask to calculate the results.
        End If
    End Sub

    Private Function ValidateTextbox(ByRef prValue As Decimal, ByRef prTextbox As TextBox) As Boolean 'Function that stores either true or false depending on whether we can put the received textbox input into the received variable.
        If (IsNumeric(prTextbox.Text) = True) Then 'checks whether the input in the textbox is a number. If it is a number, we will continue.
            prValue = CDec(prTextbox.Text) 'converts the textbox input to a decimal and stores this in the variable we got passed.
            Return True 'We have found out the user's input is a number. Now we can run the next test.
        Else
            frmTableOutput.Close() 'if the input is not a number we will close the table result form
            If (prTextbox.Text = "") Then 'detects whether the user left the textbox blank.
                MessageBox.Show("Error in: " & prTextbox.Name & vbNewLine & "You have left the textbox blank! It is needed for the conversion.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'displays error message to the user letting them know they left the textbox empty
            Else
                MessageBox.Show("Error in: " & prTextbox.Name & vbNewLine & "Please only enter numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'displays error message to the user letting them know they can only add letters
            End If
            prTextbox.Focus() 'focus' the mouse on the textbox to show the user which textbox has the error
            Return False 'the input failed the test, therefore we cannot produce a table :(
        End If
    End Function

    Private Function CheckIfIncrementZero() As Boolean 'Function that stores either true or false depending on whether we can put the received textbox input into the received variable.
        frmTableOutput.Close() 'if the increment value is 0, we will close the table results form.
        If (lcIncrement = 0) Then 'We can't allow an increment of 0 otherwise we will have an infinite loop.
            MessageBox.Show("The increment amount cannot be 0!", "Input Error Increment", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'displays error message to the user letting them know they have used illigal input for increment.
            txtIncrement.Focus() 'We will focus on the increment textbox since we know this textbox has the error.
            Return False 'Returns false as we can see the increment value is 0. Tests will be stopped as cannot produce a table using increment of 0.
        Else
            Return True 'Returns true as the increment is not 0. Now we can run the next test!
        End If
    End Function

    Private Function CheckForInfiniteLoop() As Boolean 'Function that stores either true or false depending on whether the user's start, increment and end value combination will result in an infinite loop.
        If (lcStart > lcEnd) And (lcIncrement > 0) Then 'Checks whether the increment value will allow the start value to reach the end value
            MessageBox.Show("Your start value is greater than your end value. This means that you need a negative increment.", "Infinite Loop Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'displays error message to the user letting them know they need to change their increment value. 
            Return False 'Returns false as we can see the user's input will create an infinite loop if we allow it through.
        ElseIf (lcStart < lcEnd) And (lcIncrement < 0) Then 'Checks whether the increment value will allow the start value to reach the end value
            MessageBox.Show("Your start value is less than your end value. This means that you need a positive increment.", "Infinite Loop Detected", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'displays error message to the user letting them know they need to change their increment value. 
            Return False 'Returns false as we can see the user's input will create an infinite loop if we allow it through.
        Else
            Return True 'Returns true as the program will be able to go from start -> end from the user's increment value.
        End If
    End Function

    Private Function TooManyTableResults() As Boolean 'Function that stores either true or false depending on whether the user's start, increment and end value combination will result in too many results for my table.
        Dim lc_MAX_TABLE_RESULTS As Integer = 500 'Constant variable that determines the maximum number of results allowed in my table.
        If ((lcEnd - lcStart) / lcIncrement >= lc_MAX_TABLE_RESULTS) Then 'Forcasts whether the user's input will generate 500 or more results
            MessageBox.Show("Too many results to store in the table! The table can store up to a maximum of " + CStr(lc_MAX_TABLE_RESULTS) + " results.", "Too Many Results", MessageBoxButtons.OK, MessageBoxIcon.Stop) 'displays error message to the user letting them know they need to change their input to produce less results.
            Return False 'Returns false as we can see the user's input will create too many results in the output table form.
        Else
            Return True 'Returns true as the user's input will produce a suitable number of results.
        End If
    End Function

    Private Sub GenerateTableOutput() 'This subtask will be executed if the user's input passes all the function tests.
        frmTableOutput.Show() 'The table output form will be loaded so the value and result columns can be created in the list view control
        frmTableOutput.lblConversionChoice.Text = CStr(gl_CONVERSION_CHOICES(cboConversionChoice.SelectedIndex)) 'A label in the table output form will be changed to show the user what conversion the program carried out.
        For lcCounter = lcStart To lcEnd Step lcIncrement 'This loop will run based on the user's start, increment and end values.
            Dim lcValue As Decimal = lcCounter 'Another variable is created to bring the conversion result back to this subtask
            Call ConvertValue(lcValue) 'We need to call a separate subtask that deals with converting the value. This will return us the result for the table
            Call frmTableOutput.CalculationResult(lcCounter, lcValue) 'We need to send the counter and value parameters to the calculation result subtask in the table output form so they can be added to the table.
            'We will add lcIncrement to the counter and see if we can perform another calculation.
        Next lcCounter
    End Sub
End Class