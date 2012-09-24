using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Mp3DisplayTag
    {
        public String mp3FileName { get; set; }
        private TagLib.File tagfile = null;

        public Mp3DisplayTag(String mp3filename) 
        {
            this.mp3FileName = mp3filename;
            Console.Out.WriteLine("MP3 file set to: " + this.mp3FileName);

            if ( ! System.IO.File.Exists( this.mp3FileName ) )
                throw new System.IO.FileNotFoundException();

            try
            {
                tagfile = TagLib.File.Create(this.mp3FileName);
            }
            catch (TagLib.UnsupportedFormatException e)
            {
                throw;
            }

        }

        /// <summary>
        /// Display the tags for the MP3 file. This will print to the console in a line break way the tags and their values of the MP3 file.
        /// </summary>
        /// <returns>A string with linebreaks that have the tag and their values for the ID3 tag.</returns>
        public String DisplayTags()
        {
            StringBuilder tags = new StringBuilder();
            tags.AppendLine("--------------TAGS-----------------");

            tags.AppendLine("Tags on disk:   " + tagfile.TagTypesOnDisk);
            tags.AppendLine("Tags in object: " + tagfile.TagTypes);
            tags.AppendLine(String.Empty);

            tags.AppendLine("Grouping: " + tagfile.Tag.Grouping);
            tags.AppendLine("Title: " + tagfile.Tag.Title);
            tags.AppendLine("TitleSort: " + tagfile.Tag.TitleSort);
            tags.AppendLine("Album Artists:" + String.Join(",", tagfile.Tag.AlbumArtists));
            tags.AppendLine("Album Artists Sort: " + String.Join(",", tagfile.Tag.AlbumArtistsSort));
            tags.AppendLine("Performers: " + String.Join(",",tagfile.Tag.Performers));
            tags.AppendLine("Performers Sort: " + String.Join(",", tagfile.Tag.PerformersSort));
            tags.AppendLine("Composers: " + String.Join(",",tagfile.Tag.Composers));
            tags.AppendLine("Composers Sort: " + String.Join(",",tagfile.Tag.ComposersSort));
            tags.AppendLine("Conductor: " + tagfile.Tag.Conductor);
            tags.AppendLine("Album: " + tagfile.Tag.Album);
            tags.AppendLine("Album Sort: " + tagfile.Tag.AlbumSort);
            tags.AppendLine("Comment: " + tagfile.Tag.Comment);
            tags.AppendLine("Copyright: " + tagfile.Tag.Copyright);
            tags.AppendLine("Genres: " + String.Join(",",tagfile.Tag.Genres));
            tags.AppendLine("BPM: " + tagfile.Tag.BeatsPerMinute);
            tags.AppendLine("Year: " + tagfile.Tag.Year);
            tags.AppendLine("Track: " + tagfile.Tag.Track);
            tags.AppendLine("TrackCount: " + tagfile.Tag.TrackCount);
            tags.AppendLine("Disc: " + tagfile.Tag.Disc);
            tags.AppendLine("DiscCount: " + tagfile.Tag.DiscCount);

            tags.AppendLine("Lyrics: " + tagfile.Tag.Lyrics);
            tags.AppendLine("Media Types:     " + tagfile.Properties.MediaTypes);

            foreach (TagLib.ICodec codec in tagfile.Properties.Codecs)
            {
                TagLib.IAudioCodec acodec = codec as TagLib.IAudioCodec;
                TagLib.IVideoCodec vcodec = codec as TagLib.IVideoCodec;

                if (acodec != null && (acodec.MediaTypes & TagLib.MediaTypes.Audio) != TagLib.MediaTypes.None)
                {
                    tags.AppendLine("Audio Properties : " + acodec.Description);
                    tags.AppendLine("Bitrate:    " + acodec.AudioBitrate);
                    tags.AppendLine("SampleRate: " + acodec.AudioSampleRate);
                    tags.AppendLine("Channels:   " + acodec.AudioChannels);
                }

                if (vcodec != null && (vcodec.MediaTypes & TagLib.MediaTypes.Video) != TagLib.MediaTypes.None)
                {
                    tags.AppendLine("Video Properties : " + vcodec.Description);
                    tags.AppendLine("Width:      " + vcodec.VideoWidth);
                    tags.AppendLine("Height:     " + vcodec.VideoHeight);
                }
            }

            if (tagfile.Properties.MediaTypes != TagLib.MediaTypes.None)
                tags.AppendLine("Length:     " + tagfile.Properties.Duration);

            TagLib.IPicture[] pictures = tagfile.Tag.Pictures;

            tags.AppendLine("Embedded Pictures: " + pictures.Length);

            foreach (TagLib.IPicture picture in pictures)
            {
                tags.AppendLine(picture.Description);
                tags.AppendLine("   MimeType: " + picture.MimeType);
                tags.AppendLine("   Size:     " + picture.Data.Count);
                tags.AppendLine("   Type:     " + picture.Type);
            }

            tags.AppendLine("--------------END------------------");

            return tags.ToString();
        }

    }
}
