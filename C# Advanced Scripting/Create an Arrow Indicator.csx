// Creates an arrow indicator measure for every currently selected measure
foreach(var c in Selected.Measures)
{    var newMeasure = c.Table.AddMeasure(
         c.Name + " Arrow",                    // Currently Selected Measure Name Appended with " Arrow"
         "VAR Down = UNICHAR(9660) VAR Up = UNICHAR(9650) VAR Side = UNICHAR(11208) VAR Target = 0 RETURN SWITCH(TRUE()," + c.DaxObjectFullName + "< Target, Down ," + c.DaxObjectFullName + "= Target, Side ," + c.DaxObjectFullName + " > Target, Up )"   // DAX expression
    );
}

