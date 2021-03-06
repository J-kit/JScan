﻿using System;
using System.Collections.Generic;
using System.Net;

namespace JScan.Net.Data
{
    public interface IScanStorage
    {
    }

    public class ScanStorageListData : IScanStorage
    {
        public List<IPAddress> IpAddresses;

        public ScanStorageListData()
        {
            IpAddresses = new List<IPAddress>();
        }

        public ScanStorageListData(List<IPAddress> input = null)
        {
            IpAddresses = new List<IPAddress>();
            if (input != null) IpAddresses.AddRange(input);
        }

        public ScanStorageListData(IPAddress[] input = null)
        {
            IpAddresses = new List<IPAddress>();
            if (input != null) IpAddresses.AddRange(input);
        }
    }

    public class ScanStorageMaskData : IScanStorage
    {
        public List<AddressByteCollection> MaskData;

        public ScanStorageMaskData(List<AddressByteCollection> input = null)
        {
            MaskData = new List<AddressByteCollection>();
            if (input != null) MaskData.AddRange(input);
        }
    }

    //Todo
    public class ScanStorageRangeData : IScanStorage
    {
        public ScanStorageRangeData(List<AddressByteCollection> input = null)
        {
            throw new NotImplementedException();
            //MaskData = new List<AddressByteCollection>();
            //if (input != null) MaskData.AddRange(input);
        }
    }
}