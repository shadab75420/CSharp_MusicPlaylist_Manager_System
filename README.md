# C# Music Playlist Manager System

## Problem Statement

This project implements a Music Playlist Manager using C# collections.
It allows users to manage songs, organize them by rating and artist, and maintain a playlist efficiently.

---

## Features

* Add songs with artist and rating
* Maintain playlist using LinkedList
* Sort songs by rating
* Sort songs by artist name
* Remove songs from playlist
* Display updated playlist and sorted views

---

## Technologies Used

* C#
* .NET
* Collections (LinkedList, SortedList, SortedDictionary)

---

## Data Structures Used

* **LinkedList<string>** → Maintains playlist order
* **SortedList<int, string>** → Sorts songs by rating
* **SortedDictionary<string, string>** → Sorts songs by artist

---

## Functionality Overview

### Song Management

* Add songs with artist and rating
* Prevent duplicate rating entries in SortedList
* Prevent duplicate artist entries in SortedDictionary

### Playlist Management

* Maintain insertion order using LinkedList
* Remove songs from playlist

### Sorting Features

* Display songs sorted by rating
* Display songs sorted by artist

---

## Sample Output

Song 'Blinding Lights' by The Weeknd added with rating 4

Song 'Levitating' by Dua Lipa added with rating 3

Playlist:
Shape of You
Blinding Lights
Levitating

Songs Sorted by Rating:
Rating 3: Levitating

Rating 4: Blinding Lights

Rating 5: Shape of You

Songs Sorted by Artist:
Dua Lipa: Levitating

Ed Sheeran: Shape of You
The Weeknd: Blinding Lights

Song 'Levitating' removed from playlist

Playlist:
Shape of You
Blinding Lights

Songs Sorted by Rating:
Rating 4: Blinding Lights
Rating 5: Shape of You

Songs Sorted by Artist:
Ed Sheeran: Shape of You
The Weeknd: Blinding Lights

---

## How to Run

1. Open the project in Visual Studio
2. Build the solution
3. Run the program (Ctrl + F5)

---

## Key Concepts

* C# Collections
* LinkedList for ordered data
* SortedList and SortedDictionary for sorting
* Data organization and management

## Repository Name Suggestion

CSharp_MusicPlaylist_Manager_System
