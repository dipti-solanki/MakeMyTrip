import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class FlightDetailBase {

//#region flightDetailId Prop
        @prop()
        flightDetailId : number;
//#endregion flightDetailId Prop


//#region flightId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        flightId : number;
//#endregion flightId Prop


//#region flightDetails Prop
        @required()
        @maxLength({value:50})
        flightDetails : string;
//#endregion flightDetails Prop


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


//#region amount Prop
        @required()
        amount : number;
//#endregion amount Prop


//#region reviewId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        reviewId : number;
//#endregion reviewId Prop


//#region stop Prop
        @maxLength({value:50})
        stop : string;
//#endregion stop Prop





}