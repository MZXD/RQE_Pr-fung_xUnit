Feature: Taschenrechner
    In order to avoid silly mistakes
    As a math idiot
    I want to be told the sinus, cosinus and tangens of a number

@mytag
Scenario: Calc Sinus
    Given the number is 3,1415
    When i want the Sinus
    Then the result should be 0


Scenario: Calc Cosinus
    Given the number 3.1415
    When i want the Cosinus
    Then the result should be -1


Scenario Outline: Calc Tangens
    Given the number 3.1415
    When I want the Tangens
    Then the result should be 0

