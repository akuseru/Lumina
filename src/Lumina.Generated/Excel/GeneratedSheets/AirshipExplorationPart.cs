// ReSharper disable All

using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "AirshipExplorationPart", columnHash: 0xc971f464 )]
    public class AirshipExplorationPart : IExcelRow
    {
        
        public byte Unknown0;
        public byte Rank;
        public byte Components;
        public short Surveillance;
        public short Retrieval;
        public short Speed;
        public short Range;
        public short Favor;
        public ushort Unknown8;
        public byte RepairMaterials;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Unknown0 = parser.ReadColumn< byte >( 0 );
            Rank = parser.ReadColumn< byte >( 1 );
            Components = parser.ReadColumn< byte >( 2 );
            Surveillance = parser.ReadColumn< short >( 3 );
            Retrieval = parser.ReadColumn< short >( 4 );
            Speed = parser.ReadColumn< short >( 5 );
            Range = parser.ReadColumn< short >( 6 );
            Favor = parser.ReadColumn< short >( 7 );
            Unknown8 = parser.ReadColumn< ushort >( 8 );
            RepairMaterials = parser.ReadColumn< byte >( 9 );
        }
    }
}