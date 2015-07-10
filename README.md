Noughts and Crosses
===================
a.k.a. Tic Tac Toe
------------------

A Noughts and Crosses game where the computer plays against itself.

Written by Dr. Gavin T.D. Greig, July 2015.

Dependencies
------------
The projects in this solution depend on the NuGet package manager, 
and NuGet packages that apply StyleCop style-checking rules to the
source code. An external installation of StyleCop should not be
required.

The Unit Test project also depends on packages that integrate NUnit
functionality into Visual Studio. An external installation of NUnit
should not be required.

Otherwise, this solution should be self-contained, although
unfortunately it has not been possible to test this on a machine
with minimal development software installed.

Incomplete Functionality
------------------------
The executables compile, but functionality has not been completed.
At the time of writing the following requirements are not satisfied:

* Make random moves by each player
* Offer to run another game at the end of a game
* Display the result at the end of the game

Incomplete Testing
------------------
The existing tests pass, but many more would be desirable. Some real
test-driven testing (red/green/refactor) occurred, but under time 
pressure less was done than desirable, with too much left until after
implementation and unfortunately therefore not addressed.

Signing
-------
The projects in this solution are strong-name signed for added security.
Strong-name signing allows much of the functionality to be made "internal",
and only callable by a named friend assembly signed with the same 
strong-name key (the test assembly).

In a genuine production program, executables would also be signed and timestamped
with an Authenticode certificate to identify the publisher of the assembly.
However, real Authenticode certificates have an associated cost and using
a self-signed certificate instead, while possible for development purposes, 
is awkward. Taking into account the available time, a decision was made 
not to attempt Authenticode signing on this project.

Icon
----
A production program would also be assigned a dsitinctive icon in a number
of resolutions. This step was omitted in the interests of time.

Impediments
-----------
* First time using GitHub
* First time using Markdown
* Actual hours available: ~8 (initial estimate), ~13 (actual)