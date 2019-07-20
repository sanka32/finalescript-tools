process all open


// ---- make sure we are on score first
strike alt "o"
strike "s"

//  ----- 1. Create Lead Sheet Part
//
//

//menu item "Manage Parts"
strike alt "o"
strike "m"
wait 1 second
//expect to hit "New Part"
tab 5
strike enter
//take vocal part - first in list
tab 8
button "Add to part"

//button "Edit Staff Name..."
tab 3
strike enter
strike ctrl "A"
strike shift "L"
strike "e"
strike "a"
strike "d"
strike " "
strike shift "S"
strike "h"
strike "e"
strike "e"
strike "t"
button "Ok"

button "OK"
// new part is part 3
// ----- 1 plus! Create MD Piano and Vox part


// ---- make sure we are on score first
strike alt "o"
strike "s"

//  ----- 1. Create Lead Sheet Part
//
//

//menu item "Manage Parts"
strike alt "o"
strike "m"
wait 1 second
//expect to hit "New Part"
tab 5
strike enter
//take vocal part - first in list
tab 8
button "Add to part"
// then next one = piano, if other instruments then this won't work
button "Add to part"

//button "Edit Staff Name..."
tab 3
strike enter
strike ctrl "A"
strike shift "P"
strike "i"
strike "a"
strike "n"
strike "o"
strike " "
strike "&"
strike shift "V"
strike "o"
strike "c"
strike "a"
strike "l"
strike "s"
button "Ok"

button "OK"
// new part is part 3




//  ------ 2. Copy Chords to Vocal Line and apply staff style to hide on score
//
//

// need to ensure filter is on
menu item "Edit Filter..."
click "None"
check "Chords & Fretboards"
click "Ok"
// copy chords
select staff 2
copy
// paste chords
select staff 1
paste


// need to apply staff style - choose pre-existing style, or create one and put the name here
staff tool
select staff 1
apply staff style "Hide Chords"

// -- manually set staff attributes to remove need for staff style to be defined in document. 
//strike alt "s"
//strike "t"
//uncheck "Chords"
//button "ok"

// change to Piano Vocals, apply staff style on part
strike alt "o"
strike "p"
down arrow
strike enter

staff tool
select staff 1
apply staff style "Hide Chords"


//  ------ 3 - Fit bars on part
//
//

// change to part - down arrow to part in question
strike alt "o"
strike "p"
down arrow
down arrow
strike enter



/// space staves out a little
select all
staff tool
strike alt "s"
strike "r"
check "Set to:"
strike "0"
strike "."
strike "2"
button "Ok"


// fit all  to 4 bars per line
select all
// Fit Measures 4 meas //per system
strike alt "l"
strike "f"
select radio "Remove system locks"
//wait 1 second
button "Ok"

strike alt "l"
strike "f"
select radio "Lock layout with:"
strike shift tab
strike "4"
//wait 1 second
button "Ok"


//  DONE - change to score edit
strike alt "o"
strike "s"