using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{

    abstract class Stream
    {
        abstract public void ReadStream();
    }

    class MemoryStream : Stream
    {
        public override void ReadStream()
        {
            // read stream from RAM
        }
    }

    class TcpIpStream : Stream
    {
        public override void ReadStream()
        {
            // read network stream
        }
    }

    abstract class StreamDecorator : Stream
    {
        protected Stream decoratedStream;

        private StreamDecorator() { }

        public StreamDecorator(Stream stream)
        {
            decoratedStream = stream;
        }
    }

    class BufferedStreamDecorator : StreamDecorator
    {
        public BufferedStreamDecorator(Stream stream) : base(stream) { }

        public override void ReadStream()
        {
            // read stream contents into a buffer
            decoratedStream.ReadStream();
        }
    }

    class DecompressingStreamDecorator : StreamDecorator
    {
        public DecompressingStreamDecorator(Stream stream) : base(stream) { }


        public override void ReadStream()
        {
            // decompress the stream contents as it is read
            decoratedStream.ReadStream();
        }
    }

    class UnicodeStream : StreamDecorator
    {
        public UnicodeStream(Stream stream) : base(stream) { }


        public override void ReadStream()
        {
            // convert contents from unicode to ascii
            decoratedStream.ReadStream();
        }
    }


    class Decorator
    {
        static void Main(string[] args)
        {
            TcpIpStream netStream = new TcpIpStream();
            BufferedStreamDecorator bufferedNetworkStream = new BufferedStreamDecorator(netStream);

            bufferedNetworkStream.ReadStream();

            MemoryStream ramStream = new MemoryStream();
            DecompressingStreamDecorator decompressor = new DecompressingStreamDecorator(ramStream);
            UnicodeStream encoder = new UnicodeStream(decompressor);

            encoder.ReadStream();
        }
    }
}
