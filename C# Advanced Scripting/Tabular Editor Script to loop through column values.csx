//Loop through all values in a column and create a calculated measure for each distinct row value
//Replace text with column name of values to loop through
//Confirm you don't have a ton of values in the column as this will create a measure for each value!!!
string query = "EVALUATE VALUES('DesiredTable'[DesiredColumn])";
 
using (var reader = Model.Database.ExecuteReader(query))
{
    // Create a loop for every row in the resultset creating a measure for each value and moving all of them to a folder
    while(reader.Read())
    {
        string ColumnvaluetoLoopthrough = reader.GetValue(0).ToString();
        string measureName = ColumnvaluetoLoopthrough + " Total";
        string myExpression = "CALCULATE( [DesiredMeasureName], 'DesiredTable'[DesiredColumn] = \""  + ColumnvaluetoLoopthrough + "\")";
        
        //Replace text with desired table name and desired folder name
        Model.Tables["TableNameWhereYouWantTheMeasuresToLand"].AddMeasure(measureName, myExpression, "_Loop Measures");
    }
}
