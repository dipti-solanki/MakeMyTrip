import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vBookedFlightBase {

//#region travellerId Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'travellerId', keyColumn: true})
        travellerId : number;
//#endregion travellerId Prop


//#region lastName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'lastName', keyColumn: false})
        lastName : string;
//#endregion lastName Prop


//#region firstName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'firstName', keyColumn: false})
        firstName : string;
//#endregion firstName Prop


//#region flightId Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'flightId', keyColumn: false})
        flightId : number;
//#endregion flightId Prop


//#region flightName Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'flightName', keyColumn: false})
        flightName : string;
//#endregion flightName Prop


//#region flightDetails Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'flightDetails', keyColumn: false})
        flightDetails : string;
//#endregion flightDetails Prop


//#region origin Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'origin', keyColumn: false})
        origin : string;
//#endregion origin Prop


//#region destination Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'destination', keyColumn: false})
        destination : string;
//#endregion destination Prop


//#region amount Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'amount', keyColumn: false})
        amount : number;
//#endregion amount Prop


//#region stop Prop
        @gridColumn({visible: true, columnIndex:9, allowSorting: true, headerKey: 'stop', keyColumn: false})
        stop : string;
//#endregion stop Prop


//#region flightBookingId Prop
        @gridColumn({visible: true, columnIndex:10, allowSorting: true, headerKey: 'flightBookingId', keyColumn: false})
        flightBookingId : number;
//#endregion flightBookingId Prop

}