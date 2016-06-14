﻿/***********************************************************************
Copyright 2016 Stefan Hausotte

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

*************************************************************************/

using System;

namespace PeNet.Parser
{
    public abstract class SafeParser<T>
    {
        public SafeParser(byte[] buff, uint offset)
        {
            _buff = buff;
            _offset = offset;
        }

        public Exception ParserException { get; protected set; }

        private T _target = default(T);
        private bool _alreadyParsed;
        protected readonly byte[] _buff;
        protected readonly uint _offset;

        protected abstract T ParseTarget();

        public T GetParserTarget()
        {
            if (_alreadyParsed)
                return _target;

            _alreadyParsed = true;

            try
            {
                _target = ParseTarget();
            }
            catch (Exception exception)
            {
                ParserException = exception;
            }

            return _target;
        }
    }
}