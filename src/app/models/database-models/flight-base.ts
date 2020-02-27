import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class FlightBase {

//#region flightId Prop
        @prop()
        flightId : number;
//#endregion flightId Prop


//#region flightName Prop
        @required()
        @maxLength({value:50})
        flightName : string;
//#endregion flightName Prop

}