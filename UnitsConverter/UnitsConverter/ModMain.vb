Module ModMain
    'Each conversion option is separated by a comma. This means there are 8 options.
    Public gl_CONVERSION_CHOICES As String() = _
       {"Grams to Ounces", "Ounces to Grams", "Litres to Gallons", "Gallons to Litres", "Celsius to Fahrenheit", "Fahrenheit to Celsius", "Kilograms to Stones", "Stones to Kilograms"}

    'These numbers correspond to the same index in the Conversion Choices array
    Public gl_CONVERSION_FORMULAS As Decimal() = _
        {0.035274, 28.349523, 0.264172, 3.785412, 1.8, 1.8, 0.157473, 6.350293}
    '      Grams     ounces    litres    gallons  Cel  Fah    kilo     stone 

    'The acceptable options for rounding. There are 6 different settings (0-5)
    Public gl_DECIMAL_PLACES As String() = _
        {0, 1, 2, 3, 4, 5}
End Module