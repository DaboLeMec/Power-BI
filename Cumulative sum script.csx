// Creates a Cumulative Sum measure for every currently selected measure.
foreach(var m in Selected.Measures)
{
    var newMeasure = m.Table.AddMeasure(
    "Cumulative Sum" + m.Name,                    // Name
    " VAR MAXDATE = MAX( 'Date'[Date] ) RETURN CALCULATE( " +  m.DaxObjectFullName + " , FILTER( ALL( 'Date') , 'Date'[Date] < MAXDATE ) )"
    m.DisplayFolder =   "_Cumulative Sums"                   // Display Folder
    );
}