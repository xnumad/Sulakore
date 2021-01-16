﻿namespace Sulakore.Modules
{
    public sealed class OutDataCaptureAttribute : DataCaptureAttribute
    {
        public override bool IsOutgoing => true;

        public OutDataCaptureAttribute(short id)
            : base(id)
        { }
        public OutDataCaptureAttribute(string hash)
            : base(hash)
        { }
    }
}