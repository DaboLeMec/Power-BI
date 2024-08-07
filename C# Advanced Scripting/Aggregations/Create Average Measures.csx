// Creates a SUM measure for every currently selected column and hide the column.
foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
    "AVG " + c.Name,                    // Name
        "AVERAGE(" + c.DaxObjectFullName + ")"    // DAX expression
        
    );
    
    // Set the format string on the new measure:
    newMeasure.FormatString = "#,0";


}
