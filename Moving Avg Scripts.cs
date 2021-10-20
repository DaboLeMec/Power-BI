// Creates a Moving Average measure for every currently selected column and hide the column.
foreach(var m in Selected.Measures)
{
    var newMeasure = m.Table.AddMeasure(
    "3 Week Moving Avg" + m.Name,                    // Name
    "VAR Week = 4 RETURN DIVIDE( SUMX( FILTER(  ALL( '_Date' ), _Date[RelativeFiscalWeekNumber] > MAX( _Date[RelativeFiscalWeekNumber] ) - Week &&_Date[RelativeFiscalWeekNumber] <= MAX( _Date[RelativeFiscalWeekNumber] )  )," + m.DaxObjectFullName + ") , Week )",
     m.DisplayFolder =   "_Moving Avgs"                   // Display Folder
    );
}
