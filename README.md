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

Incomplete Testing
------------------
The existing tests pass, but many more would be desirable. Some real
test-driven testing (red/green/refactor) occurred, but under time 
pressure much less was done than desirable, with too much left until after
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
A production program would also be assigned a distinctive icon in a number
of resolutions. This step was omitted in the interests of time.

Impediments
-----------
* First time using GitHub (minor)
* First time using Markdown (minor)
* Actual hours available: with travel, 2 evenings after 8 o'clock, plus what
I could manage elsewhere. (significant)
* Decision to take "production ready" literally (medium). Could have dialled
back on things like the use of code quality tools, paying attention to code
security (e.g. defaulting to internal rather than public), and signing, but
these are things it's good to get in place from the start and which I would
usually aim to do in production.

What could be done better
-------------------------
* More testing
* Use Inversion of Control to separate out decisions about concrete classes 
from where they're used. This wasn't attempted because of time. Our portability
work dating back to 2005 used hand-written Factories to achieve this, before
the easy availability of IOC frameworks, so I don't have good familiarity
with a single framework to pick and run with. With more time, I would
look into adopting a framework such as Autofac or Ninject.
* Separate Views from the Model. It's less natural to think of a command line
program in these terms, and I fell into that trap in the process of trying
to get functionality established; but in a production program, with more time,
it would be worth refactoring to establish that separation. Broadly, I would 
expect a View to represent each turn (probably with a subview for the actual 
game state), and other views for other interactions such as the game 
introduction. Behind the views I would prefer to use ViewModels (MVVM) which
would be easily drivable for testing, and relatively easy to apply new UI 
skins to - such as a Windows, mobile or web version.