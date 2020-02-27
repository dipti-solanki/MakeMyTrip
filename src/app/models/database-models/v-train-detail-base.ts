import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vTrainDetailBase {

//#region availableDay Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'availableDay', keyColumn: false})
        availableDay : string;
//#endregion availableDay Prop


//#region trainDetails Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'trainDetails', keyColumn: false})
        trainDetails : string;
//#endregion trainDetails Prop


//#region class Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'class', keyColumn: false})
        class : string;
//#endregion class Prop


//#region origin Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'origin', keyColumn: false})
        origin : string;
//#endregion origin Prop


//#region destination Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'destination', keyColumn: false})
        destination : string;
//#endregion destination Prop


//#region amount Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'amount', keyColumn: false})
        amount : number;
//#endregion amount Prop


//#region trainName Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'trainName', keyColumn: false})
        trainName : string;
//#endregion trainName Prop


//#region trainId Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'trainId', keyColumn: true})
        trainId : number;
//#endregion trainId Prop

}