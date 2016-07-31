﻿using System;

namespace CoCSharp.Network.Messages.Commands
{
    /// <summary>
    /// Command that is sent by the server to the client to
    /// tell it that its name was changed.
    /// </summary>
    public class ChangeAvatarNameCommand : Command
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeAvatarNameCommand"/> class.
        /// </summary>
        public ChangeAvatarNameCommand()
        {
            // Space
        }

        /// <summary>
        /// Gets the ID of the <see cref="ChangeAvatarNameCommand"/>.
        /// </summary>
        public override int ID { get { return 3; } }

        /// <summary>
        /// New name confirmed by server.
        /// </summary>
        public string NewName;

        /// <summary>
        /// Unknown integer 1.
        /// </summary>
        public int Unknown1;
        /// <summary>
        /// Unknown integer 2.
        /// </summary>
        public int Unknown2;

        /// <summary>
        /// Reads the <see cref="ChangeAvatarNameCommand"/> from the specified <see cref="MessageReader"/>.
        /// </summary>
        /// <param name="reader">
        /// <see cref="MessageReader"/> that will be used to read the <see cref="ChangeAvatarNameCommand"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="reader"/> is null.</exception>
        public override void ReadCommand(MessageReader reader)
        {
            ThrowIfReaderNull(reader);

            NewName = reader.ReadString();

            Unknown1 = reader.ReadInt32();
            Unknown2 = reader.ReadInt32();
        }

        /// <summary>
        /// Writes the <see cref="ChangeAvatarNameCommand"/> to the specified <see cref="MessageWriter"/>.
        /// </summary>
        /// <param name="writer">
        /// <see cref="MessageWriter"/> that will be used to write the <see cref="ChangeAvatarNameCommand"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="writer"/> is null.</exception>
        public override void WriteCommand(MessageWriter writer)
        {
            ThrowIfWriterNull(writer);

            writer.Write(NewName);

            writer.Write(Unknown1);
            writer.Write(Unknown2);
        }
    }
}
