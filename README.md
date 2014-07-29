Phase_10_Scorecard
==================

Scorecard used for the Phase 10 card game.

I first created this application as a gift for my mother who loved playing Phase 10 as a family.  I created an initial
application that left much to be desired due to a fair amount of replication in regards to the leveling function.  This
is my last version of the scorecard application, with newer versions coming as I implement changes my mother would like made.

###########################
## Features To Highlight ##
###########################

1)  The most important feature I included in this version of the Phase 10 Scorecard application was the introduction of the
    drag & drop score.  For easier use with tablets, I programmed the application so that the scores can simply be dragged
    and dropped from the listbox of values to the the user's score box.

2)  For each round, the user's score is calculated automatically once a new value is dropped into the user's score box.  If
    the value dropped in the user's score box is <= 45, the user's Phase 10 level is automatically increased by one as they
    completed a phase.  If the user's score is >= 50, the user's Phase 10 level remains the same as they did not complete a
    phase.  This automation is how I eliminated the repetition in my code, and eliminated the need for the score keeper to
    remember who completed a phase and who did not.

3)  Finally, in the event of a mistake, I included a method for undoing previous moves.  Clicking the "Undo Last" button
    will reset and undo each previous move made back to the beginning of the game.
