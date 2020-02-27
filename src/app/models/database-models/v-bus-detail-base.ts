import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vBusDetailBase {

//#region availableDay Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'availableDay', keyColumn: false})
        availableDay : string;
//#endregion availableDay Prop


//#region busDetails Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'busDetails', keyColumn: false})
        busDetails : string;
//#endregion busDetails Prop


//#region origin Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'origin', keyColumn: false})
        origin : string;
//#endregion origin Prop


//#region destination Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'destination', keyColumn: false})
        destination : string;
//#endregion destination Prop


//#region leftSeats Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'leftSeats', keyColumn: true})
        leftSeats : number;
//#endregion leftSeats Prop


//#region amount Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'amount', keyColumn: false})
        amount : number;
//#endregion amount Prop


//#region busName Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'busName', keyColumn: false})
        busName : string;
//#endregion busName Prop


//#region busType Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'busType', keyColumn: false})
        busType : string;
//#endregion busType Prop


//#region transport Prop
        @gridColumn({visible: true, columnIndex:9, allowSorting: true, headerKey: 'transport', keyColumn: false})
        transport : string;
//#endregion transport Prop


//#region busId Prop
        @gridColumn({visible: true, columnIndex:10, allowSorting: true, headerKey: 'busId', keyColumn: false})
        busId : number;
//#endregion busId Prop

}