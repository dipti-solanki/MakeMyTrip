import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vBookedCabBase {

//#region travellerId Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'travellerId', keyColumn: true})
        travellerId : number;
//#endregion travellerId Prop


//#region firstName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'firstName', keyColumn: false})
        firstName : string;
//#endregion firstName Prop


//#region lastName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'lastName', keyColumn: false})
        lastName : string;
//#endregion lastName Prop


//#region cabId Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'cabId', keyColumn: false})
        cabId : number;
//#endregion cabId Prop


//#region cabName Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'cabName', keyColumn: false})
        cabName : string;
//#endregion cabName Prop


//#region cabDetails Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'cabDetails', keyColumn: false})
        cabDetails : string;
//#endregion cabDetails Prop


//#region facilities Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'facilities', keyColumn: false})
        facilities : string;
//#endregion facilities Prop


//#region amount Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'amount', keyColumn: false})
        amount : number;
//#endregion amount Prop


//#region origin Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'origin', keyColumn: false})
        origin : string;
//#endregion origin Prop


//#region destination Prop
        @gridColumn({visible: true, columnIndex:9, allowSorting: true, headerKey: 'destination', keyColumn: false})
        destination : string;
//#endregion destination Prop


//#region cabBookingId Prop
        @gridColumn({visible: true, columnIndex:10, allowSorting: true, headerKey: 'cabBookingId', keyColumn: false})
        cabBookingId : number;
//#endregion cabBookingId Prop

}