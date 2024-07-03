// Creates a SUM measure for every currently selected column and hide the column.
foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
        "_" + c.Name,                    // Name
        "SUM(" + c.DaxObjectFullName + ")",    // DAX expression
        c.DisplayFolder  = "_Calcs"            // Display Folder
    );
    
    // Set the format string on the new measure:
    newMeasure.FormatString = "#,0";

}
