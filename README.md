<h1 align="center"> ModuleCalculator </h1>

<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->
## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Contributors](#contributors)
- [Acknowledgments](#acknowledgments)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

## Introduction

View available modules for your course and control/mannage your time by viewing & calculating the required time to efficiently pass your modules. Built with C#, the ModuleCalculator is one of the most feature-rich unofficial application out now.


<p align="center">
  <img src = "https://i.imgur.com/8iugo9U.png" width=500>
</p>

## Features

A few of the things you can do with ModuleCalculator:

* Register and View your course modules
* View allocated hours & credits for your course
* Calculate your time margins based on semester length
* Record your time spent on a module as you work
* Calculate how much time you need or have left for the specific module

<p align="center">
  <img src = "https://i.imgur.com/UFMtWuD.png" width=700>
</p>


## Running the Program
###  Pre-Requisites:
- Open the ["ModuleCalculator Database.sql"](https://github.com/IIEWFL/prog6212-part-2-ST10067544-Thato/blob/main/ModuleCalculator%20Database.sql) file first using any SQL supported program to get the required database for users and modules.
- You will also need to modify the Data Source in the Connection strings across the whole application to match your local machine so that it runs optimally. (see below)
<p align="center">
  <img src = "https://i.imgur.com/qIQ0EzU.png" width=700>
</p>

<p align="center">
  <img src = "https://i.imgur.com/Zqy2Tii.png" width=700>
</p>

- Once all tables are loaded, you will need to register and then once success, only then will you have access to the application's full potential.

### What to expect:
- Upon successful registration and login, you will be met with the "Select Modules" page which will require of the user to choose their modules etc. & then 
click "Submit" to display their total allocated hours and etc.

- The user will then have to proceed to the next menu option on the far left named "Calculate Module Hours" where 
  they will be able to record their times allocated to a certain module and see how much time they have left to be
  considered "efficient" enough for the module.

- After all necessary information is entered and the user is satisfied with the output, they then have the option to exit
  the application with the last option on the bottom left corner.

<p align="center">
  <img src = "https://i.imgur.com/cAH21lJ.png" width=700>
</p>

##  Contributors

- Thato Sebelemetja - *Author of Initial Development*

## Acknowledgments

Thanks to my friend [Ntsako](https://www.youtube.com/@bomcodi9517) for helping me with the Custom Class Library & displaying the input onto the TextBox.