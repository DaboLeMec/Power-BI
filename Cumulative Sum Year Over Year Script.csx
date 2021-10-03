// Creates a Cumulative Sum measure for every currently selected measure that resets each Year.
foreach(var m in Selected.Measures)
{
    var newMeasure = m.Table.AddMeasure(
    "Cumulative Sum" + m.Name,                    // Name
    "VAR MAXDATE = MAX( 'Date'[Date] ) VAR MAXYear =  MAX( 'Date'[Year] ) RETURN CALCULATE(  " +  m.DaxObjectFullName + "  , FILTER( ALL( 'Date') , 'Date'[Date] < MAXDATE && 'Date'[Year] = MAXYear))",
    m.DisplayFolder =   "_Cumulative Sums"                   // Display Folder
    );
}
