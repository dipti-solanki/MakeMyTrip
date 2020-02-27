import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class LocalityBase {

//#region localityId Prop
        @prop()
        localityId : number;
//#endregion localityId Prop


//#region localityName Prop
        @required()
        @maxLength({value:50})
        localityName : string;
//#endregion localityName Prop


//#region hotelId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        hotelId : number;
//#endregion hotelId Prop


//#region cityId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        cityId : number;
//#endregion cityId Prop





}