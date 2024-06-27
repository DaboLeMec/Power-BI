// Creates a Cumulative Sum measure for every currently selected measure that resets each month.
foreach(var m in Selected.Measures)
{
    var newMeasure = m.Table.AddMeasure(
    "Cumulative Sum" + m.Name,                    // Name
    "VAR MAXDATE = MAX( 'Date'[Date] ) VAR MAXMonth = EOMONTH( MAX( 'Date'[Date] ), 0 ) RETURN CALCULATE(  " +  m.DaxObjectFullName + "  , FILTER( ALL( 'Date') , 'Date'[Date] < MAXDATE && EOMONTH( 'Date'[Date] ,0 ) = MAXMonth))",
    m.DisplayFolder =   "_Cumulative Sums"                   // Display Folder
    );
    // Set the format string on the new measure:
    newMeasure.FormatString = "#,0";
}
