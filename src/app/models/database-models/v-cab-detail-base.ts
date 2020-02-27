import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vCabDetailBase {

//#region cabName Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'cabName', keyColumn: false})
        cabName : string;
//#endregion cabName Prop


//#region cabDetails Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'cabDetails', keyColumn: false})
        cabDetails : string;
//#endregion cabDetails Prop


//#region facilities Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'facilities', keyColumn: false})
        facilities : string;
//#endregion facilities Prop


//#region cabId Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'cabId', keyColumn: true})
        cabId : number;
//#endregion cabId Prop


//#region cabDetailId Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'cabDetailId', keyColumn: false})
        cabDetailId : number;
//#endregion cabDetailId Prop


//#region amount Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'amount', keyColumn: false})
        amount : number;
//#endregion amount Prop


//#region reviewId Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'reviewId', keyColumn: false})
        reviewId : number;
//#endregion reviewId Prop


//#region expr1 Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'expr1', keyColumn: false})
        expr1 : number;
//#endregion expr1 Prop


//#region cabs Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'cabs', keyColumn: false})
        cabs : number;
//#endregion cabs Prop


//#region origin Prop
        @gridColumn({visible: true, columnIndex:9, allowSorting: true, headerKey: 'origin', keyColumn: false})
        origin : string;
//#endregion origin Prop


//#region destination Prop
        @gridColumn({visible: true, columnIndex:10, allowSorting: true, headerKey: 'destination', keyColumn: false})
        destination : string;
//#endregion destination Prop


//#region availableDay Prop
        @gridColumn({visible: true, columnIndex:11, allowSorting: true, headerKey: 'availableDay', keyColumn: false})
        availableDay : string;
//#endregion availableDay Prop

}