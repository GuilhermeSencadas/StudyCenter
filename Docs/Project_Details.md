# Study Center

## 0. Index

|                      Contents                      |
| :------------------------------------------------: |
|    [1. Basic Explanation](#1-basic-explanation)    |
| [2. Detailed Information](#2-detailed-information) |
|              [3. Modules](#3-modules)              |


## 1. Basic Explanation

I came up with this project when I remembered how it used to be hard to study and challenge myself. I saw some people create their own Question Cards with the answers in the back, but I didn't like the idea of 'wasting' all that paper and putting all the time to create those.

Therefore, I wanted to try to create a Hub to allow any student/ teacher to create their own tests.

---

## 2. Detailed Information

This project is to create a better and customizable study environment in a simple and fast way.

To organize this project there will be **Subjects**. A subject will be defined by a unique five-letter code (Eg. LAPR, MATHS), the subject's full name (Laboratory Project, Mathematics) with a maximum of 20 chars and a 50-letter description . 

To further sort the topics related to each subject, we'll have **Categories** that will compact the questions. Each category has a name (Eg. Adition, Subtraction, Division) and a description (Eg. See X content). The names must be unique under the subject they're placed into.

Each category will then have multiple questions composed by a number that will be generated with the test (Eg. '1.', '2.'), the text content (Eg. How much is 1+1?), the question type (Eg. Free-Text, Single-Choice).

---

## 3. Modules

The app I want to achieve at the momment has the following modules:

* **Auth** - Handles the Authentication process.
* **Logistics** - Contains all questionnaire related content.
* **SPA** - Single Page Application using Angular to dynamically render new contents as the UI.
---

## 4. Tasks

The current and planned tasks will be available at [My Trello Project](https://trello.com/b/9G8NCfCr/study-center).

---

## 5. Requirements

For the application I have some requirements I want to meet.

* Create a RESTful API;
* Follow the Onion Architecture;
* Follow the SOLID principles;