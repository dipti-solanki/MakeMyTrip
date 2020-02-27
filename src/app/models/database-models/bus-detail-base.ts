import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class BusDetailBase {

//#region busDetailId Prop
        @prop()
        busDetailId : number;
//#endregion busDetailId Prop


//#region busId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        busId : number;
//#endregion busId Prop


//#region busDetails Prop
        @required()
        @maxLength({value:50})
        busDetails : string;
//#endregion busDetails Prop


//#region origin Prop
        @required()
        @maxLength({value:50})
        origin : string;
//#endregion origin Prop


//#region destination Prop
        @required()
        @maxLength({value:50})
        destination : string;
//#endregion destination Prop


//#region date Prop
        @required()
        date : any;
//#endregion date Prop


//#region leftSeats Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        leftSeats : number;
//#endregion leftSeats Prop


//#region amount Prop
        @required()
        amount : number;
//#endregion amount Prop


//#region reviewId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        reviewId : number;
//#endregion reviewId Prop


//#region busType Prop
        @maxLength({value:50})
        busType : string;
//#endregion busType Prop


//#region transport Prop
        @maxLength({value:50})
        transport : string;
//#endregion transport Prop







}