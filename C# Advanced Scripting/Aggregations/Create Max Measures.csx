##create a c# script for tabular editor the create a min measure for every selected column
// Create a Min measure for every currently selected column and hide the column.
foreach(var c in Selected.Columns)
{
    var newMeasure = c.Table.AddMeasure(
    "MAX " + c.Name,                    // Name
        "MAX(" + c.DaxObjectFullName + ")"    // DAX expression
        
    );
    


}