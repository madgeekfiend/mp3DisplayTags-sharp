MP3DisplayTags
==============

Usage
-----

From the command line type in:
Mp3DisplayTag <path/to/mp3/file> <return>

Background
----------

Written in C# as a command line program. Uses the taglib-sharp library available at https://github.com/mono/taglib-sharp. 

Example Outcome
---------------

This program takes in an argument that is the full path to an MP3 file and print
s out the ID tag of the MP3 file.
MP3 file set to: d:\Big_Scary-Autumn.mp3
--------------TAGS-----------------
Tags on disk:   Id3v2
Tags in object: Id3v1, Id3v2

Grouping:
Title: Autumn
TitleSort:
Album Artists:
Album Artists Sort:
Performers: Big Scary
Performers Sort:
Composers:
Composers Sort:
Conductor:
Album: The Big Scary Four Seasons
Album Sort:
Comment:
Copyright:
Genres: Indie Rock
BPM: 0
Year: 2010
Track: 8
TrackCount: 13
Disc: 0
DiscCount: 0
Lyrics:
Media Types:     Audio
Audio Properties : MPEG Version 1 Audio, Layer 3
Bitrate:    160
SampleRate: 44100
Channels:   2
Length:     00:03:53.3120000
Embedded Pictures: 0
--------------END------------------

