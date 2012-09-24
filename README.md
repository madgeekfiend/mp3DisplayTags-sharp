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
s out the ID tag of the MP3 file.<br />
MP3 file set to: d:\Big_Scary-Autumn.mp3<br />
--------------TAGS-----------------<br />
Tags on disk:   Id3v2<br />
Tags in object: Id3v1, Id3v2<br />
<br />
Grouping:<br />
Title: Autumn<br />
TitleSort:<br />
Album Artists:<br />
Album Artists Sort:<br />
Performers: Big Scary<br />
Performers Sort:<br />
Composers:<br />
Composers Sort:<br />
Conductor:<br />
Album: The Big Scary Four Seasons<br />
Album Sort:<br />
Comment:<br />
Copyright:<br />
Genres: Indie Rock<br />
BPM: 0<br />
Year: 2010<br />
Track: 8<br />
TrackCount: 13<br />
Disc: 0<br />
DiscCount: 0<br />
Lyrics:<br />
Media Types:     Audio<br />
Audio Properties : MPEG Version 1 Audio, Layer 3<br />
Bitrate:    160<br />
SampleRate: 44100<br />
Channels:   2<br />
Length:     00:03:53.3120000<br />
Embedded Pictures: 0<br />
--------------END------------------<br />

