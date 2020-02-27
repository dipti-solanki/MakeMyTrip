import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vFlightDetailBase {

//#region origin Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'origin', keyColumn: false})
        origin : string;
//#endregion origin Prop


//#region destination Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'destination', keyColumn: false})
        destination : string;
//#endregion destination Prop


//#region flightDetails Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'flightDetails', keyColumn: false})
        flightDetails : string;
//#endregion flightDetails Prop


//#region availableDay Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'availableDay', keyColumn: false})
        availableDay : string;
//#endregion availableDay Prop


//#region flightName Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'flightName', keyColumn: false})
        flightName : string;
//#endregion flightName Prop


//#region amount Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'amount', keyColumn: false})
        amount : number;
//#endregion amount Prop


//#region stop Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'stop', keyColumn: false})
        stop : string;
//#endregion stop Prop


//#region flightId Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'flightId', keyColumn: true})
        flightId : number;
//#endregion flightId Prop

}