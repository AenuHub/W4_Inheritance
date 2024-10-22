## W4_Inheritance 

### Overview
This project implements a base class `BasePerson` with two derived classes `Student`and `Teacher`. The classes are designed to manage personal details, such as name and surname, along with additional details specific to students and teachers.

### Class Structure

#### 1. BasePerson
**Properties:**
- `FirstName` (str): The first name of the person.
- `LastName` (str): The last name of the person.

**Methods:**
- `PrintFullInfo()`: This method is an abstract one, in order to override in inherited classes.

#### 2. Student (Inherits from `BasePerson`)
**Additional Properties:**
- `StudentId` (int): The student's id number.

**Overridden Methods:**
- `PrintFullInfo()`: This method prints the name, surname, and student id number to the console. It overrides the `PrintFullInfo()` method from `BasePerson` within it.

#### 3. Teacher (Inherits from `BasePerson`)
**Additional Properties:**
- `Salary` (int): The teacher's salary information.

**Overridden Methods:**
- `PrintFullInfo()`: This method prints name, surname, and the teacher's salary to the console. It overrides the `PrintFullInfo()` method from `BasePerson` within it.

### How It Works
- The `BasePerson` class provides the core properties for handling name and surname, also a `PrintFullInfo()` method to be overridden.
- The `Student` and `Teacher` classes extend `BasePerson` by adding specific properties (`StudentId` and `Salary`, respectively) and overrides `PrintFullInfo()` method that print their unique information.
- Both the student and teacher methods make use of the base class method for name and surname to avoid code duplication.
